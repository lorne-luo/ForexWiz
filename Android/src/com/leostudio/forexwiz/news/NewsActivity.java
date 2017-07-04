package com.leostudio.forexwiz.news;

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

import com.leostudio.forexwiz.Main;
import com.leostudio.forexwiz.R;
import com.leostudio.forexwiz.Urls;
import com.leostudio.util.DialogFactory;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.ListActivity;
import android.app.ProgressDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.res.Configuration;
import android.graphics.Color;
import android.os.Bundle;
import android.os.Message;
import android.text.method.LinkMovementMethod;
import android.text.util.Linkify;
import android.util.Log;
import android.view.ContextThemeWrapper;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.TextView;
import android.widget.Toast;
import com.mobclick.android.MobclickAgent;

public class NewsActivity extends Activity {
	private Timer timer;
	private TimerTask task;
	private NewsAdapter newsAdapter;
	private ListView newsListView;
	private LinearLayout TopLayout;
	private int loopinterval = 20000;
	public static ArrayList<NewsBean> news = new ArrayList<NewsBean>();
	public static String last_id;

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.news_main);
		Calendar cal = Calendar.getInstance();
		int day = cal.get(Calendar.DATE);
		int month = cal.get(Calendar.MONTH) + 1;
		((TextView) findViewById(R.id.header)).setText(getString(R.string.news)+" "+month+"月"+day+"日");
		
		this.newsListView = (ListView) findViewById(R.id.news_list);

		this.newsAdapter = new NewsAdapter(this, new NewsParser());
		this.newsListView.setAdapter(newsAdapter);

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
		if (news.size() < 1)
			showLoadingDialog();
		else
			this.newsAdapter.setData(news);
		timer.schedule(task, 0, loopinterval);
	}

	private void Loop() {
		try {
			new NewsParser() {
				// 重写了Parser里的handleMessage
				@Override
				public boolean handleMessage(Message msg) {
					if (msg.what == 200) {
						onParseSuccess(msg.obj);
					} else if (msg.what == 403) {
						onParseFailed("目前没有新闻");
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
		// this.priceAdapter.resetPrices();
	}

	@Override
	protected void onDestroy() {
		if (this.loadingDialog != null)
			this.loadingDialog.dismiss();
		super.onDestroy();
	}

	public void onNewsChanged(List<NewsBean> paramList) {
		this.newsAdapter.setData(paramList);
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
		ArrayList<NewsBean> list = (ArrayList<NewsBean>) obj;
		if (list.size() > 0) {
			// news.addAll(list);// 增量式更新
			news = list;
			this.newsAdapter.setData(news);
//			Toast.makeText(this, "更新 " + String.valueOf(list.size()) + " 条新闻",
//					Toast.LENGTH_SHORT).show();
		}
		if (last_id != news.get(0).getId()) {
			last_id = news.get(0).getId();
			//!!通知有新新闻
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
	public void onNewsClick(View v) {

		AlertDialog.Builder builder = new AlertDialog.Builder(this).setTitle(
				news.get(v.getId()).getTime()).setIcon(
				android.R.drawable.btn_star).setMessage(
				news.get(v.getId()).getContent()).setNegativeButton("返     回",
				new DialogInterface.OnClickListener() {
					@Override
					public void onClick(DialogInterface dialog, int which) {
					}
				});
		AlertDialog dialog = builder.create();
		dialog.show();
	}

	public NewsActivity() {
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
				newsAdapter.notifyAnimatedDataSetChanged(true);
			}
		};
	}

	private final Runnable hideDialog;
	private ProgressDialog loadingDialog;
	private final Runnable notifyDataChanged;

	public void showLoadingDialog() {
		if (this.loadingDialog == null) {
			this.loadingDialog = DialogFactory.showProgressDialog(this,
					R.string.loading_news_titile,
					R.string.loading_news_please_wait);
		} else {
			this.loadingDialog.show();
		}
	}

	public void hideLoadingDialog() {
		Runnable localRunnable = this.hideDialog;
		runOnUiThread(localRunnable);
		// ((ImageView)
		// this.findViewById(R.id.loadingImg)).setBackgroundResource(R.drawable.rates_trend_down);
		// ((ImageView) this.findViewById(R.id.loadingImg)).setVisibility(0);
	}

	public void ShowToast(String str) {
		Toast.makeText(this, str, Toast.LENGTH_SHORT).show();
	}
	
	@Override
	public void onConfigurationChanged(Configuration config) {
	    super.onConfigurationChanged(config);
	}
}