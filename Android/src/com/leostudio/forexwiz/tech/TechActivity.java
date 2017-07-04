package com.leostudio.forexwiz.tech;

import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Timer;
import java.util.TimerTask;

import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.protocol.HTTP;
import org.apache.http.util.ByteArrayBuffer;

import com.leostudio.forexwiz.R;
import com.leostudio.forexwiz.Urls;
import com.leostudio.forexwiz.news.NewsBean;
import com.leostudio.util.DialogFactory;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.ListActivity;
import android.app.ProgressDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.os.Message;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.TextView;
import android.widget.Toast;
import com.mobclick.android.MobclickAgent;

public class TechActivity extends Activity {
	private Timer timer;
	private TimerTask task;
	private TechAdapter techAdapter;
	private ListView techListView;
	private int loopInterval = 25000;
	public static ArrayList<TechBean> techs = new ArrayList<TechBean>();

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.tech_main);
		Calendar cal = Calendar.getInstance();
		int day = cal.get(Calendar.DATE);
		int month = cal.get(Calendar.MONTH) + 1;
		((TextView) findViewById(R.id.header)).setText(getString(R.string.tech)+" "+month+"月"+day+"日");
		this.techListView = (ListView) findViewById(R.id.tech_list);

		this.techAdapter = new TechAdapter(this, new TechParser());
		this.techListView.setAdapter(techAdapter);

		timer = new Timer();
		task = new TimerTask() {
			@Override
			public void run() {
				runOnUiThread(new Runnable() {
					@Override
					public void run() {
						Loop();
					}
				});
			}
		};
		if (techs.size() < 1)
			showLoadingDialog();
		else
			this.techAdapter.setData(techs);
		timer.schedule(task, 0, loopInterval);
	}

	private void Loop() {
		try {
			new TechParser() {
				// 重写了Parser里的handleMessage
				@Override
				public boolean handleMessage(Message msg) {
					if (msg.what == 200) {
						onParseSuccess(msg.obj);
					} else if (msg.what == 403) {
						onParseFailed("目前没有技术分析");
						Urls.SwitchSite();
					} else {
						onParseFailed(R.string.loading_failed);
						Urls.SwitchSite();
					}
					return false;
				}
			}.execute(this);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	@Override
	protected void onActivityResult(int paramInt1, int paramInt2,
			Intent paramIntent) {
		super.onActivityResult(paramInt1, paramInt2, paramIntent);
		// showLoadingDialog();
	}

	@Override
	protected void onDestroy() {
		if (this.loadingDialog != null)
			this.loadingDialog.dismiss();
		super.onDestroy();
	}

	public void onTechChanged(List<TechBean> paramList) {
		this.techAdapter.setData(paramList);
		hideLoadingDialog();
	}

	public void refreshView() {
		// boolean bool = this.priceListView.post(this.notifyDataChanged);
	}

	public static byte[] readStream(InputStream inStream) throws Exception {
		ByteArrayOutputStream outStream = new ByteArrayOutputStream();
		byte[] buffer = new byte[1024];
		int len = -1;
		// 将输入流不断的读，并放到缓冲区中去。直到读完
		while ((len = inStream.read(buffer)) != -1) {
			// 将缓冲区的数据不断的写到内存中去。
			outStream.write(buffer, 0, len);
		}
		outStream.close();
		inStream.close();
		return outStream.toByteArray();
	}

	@Override
	protected void onPause() {
		super.onPause();
		if (timer != null) {
			timer.cancel();
			timer = null;
		}
		MobclickAgent.onPause(this);
	}

	@Override
	protected void onResume() {
		super.onResume();
		MobclickAgent.onResume(this);
	}

	// 取数据成功的回调
	public void onParseSuccess(Object obj) {
		ArrayList<TechBean> list = (ArrayList<TechBean>) obj;
		if (list.size() > 0) {
			// techs.addAll(list);//增量式更新
			techs = list;
			this.techAdapter.setData(techs);
			// Toast.makeText(this, "更新 " + String.valueOf(list.size()) +
			// " 条数据分析",
			// Toast.LENGTH_SHORT).show();
		}
		hideLoadingDialog();
	}

	// 取数据失败的回调
	public void onParseFailed(Object obj) {
		hideLoadingDialog();
		Toast.makeText(this, R.string.loading_failed, Toast.LENGTH_SHORT)
				.show();
		// timer.notify();
	}

	// 响应点击新闻标题
	public void onTechClick(View v) {

		AlertDialog.Builder builder = new AlertDialog.Builder(this).setTitle(
				techs.get(v.getId()).getTitle()).setIcon(
				android.R.drawable.btn_star).setMessage(
				"阻力位:\n" + techs.get(v.getId()).getUp().replace(",", "  ")
						+ "\n支撑位:\n"
						+ techs.get(v.getId()).getDown().replace(",", "  "))
				.setNegativeButton("返     回",
						new DialogInterface.OnClickListener() {
							@Override
							public void onClick(DialogInterface dialog,
									int which) {
							}
						});
		AlertDialog dialog = builder.create();

		dialog.show();

	}

	public TechActivity() {
		hideDialog = new Runnable() {
			@Override
			public void run() {
				if ((loadingDialog != null) && (loadingDialog.isShowing()))
					loadingDialog.hide();
			}
		};
		notifyDataChanged = new Runnable() {
			@Override
			public void run() {
				techAdapter.notifyAnimatedDataSetChanged(true);
			}
		};
	}

	private final Runnable hideDialog;
	private ProgressDialog loadingDialog;
	private final Runnable notifyDataChanged;

	public void showLoadingDialog() {
		if (this.loadingDialog == null) {
			this.loadingDialog = DialogFactory.showProgressDialog(this,
					R.string.loading_tech_titile,
					R.string.loading_tech_please_wait);
		} else {
			this.loadingDialog.show();
		}
	}

	public void ToastShow(String s) {
		Toast.makeText(this, s, 1).show();
	}

	public void hideLoadingDialog() {
		Runnable localRunnable = this.hideDialog;
		runOnUiThread(localRunnable);
		// ((ImageView)
		// this.findViewById(R.id.loadingImg)).setBackgroundResource(R.drawable.tech_trend_down);

	}
}