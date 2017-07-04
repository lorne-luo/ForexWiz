package com.leostudio.forexwiz.price;

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
import com.leostudio.forexwiz.price.PriceAdapter.ViewHolder;
import com.leostudio.util.DialogFactory;

import android.app.Activity;
import android.app.ListActivity;
import android.app.ProgressDialog;
import android.content.Intent;
import android.content.res.Configuration;
import android.os.Bundle;
import android.os.Message;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.AdapterView.OnItemClickListener;
import com.mobclick.android.MobclickAgent;

public class PriceActivity extends Activity {
	private Timer timer;
	private TimerTask task;
	private PriceAdapter priceAdapter;
	private ListView priceListView;
	private LinearLayout TopLayout;
	private int loopinterval = 15000;

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.price_main);
		Calendar cal = Calendar.getInstance();
		int day = cal.get(Calendar.DATE);
		int month = cal.get(Calendar.MONTH) + 1;
		((TextView) findViewById(R.id.header)).setText(getString(R.string.price)+" "+month+"月"+day+"日");
		this.priceListView = (ListView) findViewById(R.id.price_list);

		this.priceAdapter = new PriceAdapter(this, new PriceParser());
		this.priceListView.setAdapter(priceAdapter);

		this.TopLayout = (LinearLayout) findViewById(R.id.top_layout);

		// 如果有参数传进来
		// if (paramBundle != null)
		// {
		// ArrayList localArrayList = new ArrayList();
		// Iterator localIterator =
		// paramBundle.getParcelableArrayList("prices").iterator();
		// while (localIterator.hasNext())
		// {
		// Price localPrice = (Price)(Parcelable)localIterator.next();
		// boolean bool2 = localArrayList.add(localPrice);
		// }
		// this.ratesAdapter.setPrices(localArrayList);
		// }

		timer = new Timer();
		task = new TimerTask() {
			@Override
			public void run() {
				// try {
				// timer.wait();
				// } catch (InterruptedException e) {
				// e.printStackTrace();
				// }
				runOnUiThread(new Runnable() {
					@Override
					public void run() {
						Loop();
					}
				});
			}
		};
		showLoadingDialog();
		timer.schedule(task, 0, loopinterval);
		
		priceListView.setOnItemClickListener(new OnItemClickListener() {
			@Override
			public void onItemClick(AdapterView<?> arg0, View arg1, int arg2,
					long arg3) {
				ViewHolder holder = null;
				holder = (ViewHolder) arg1.getTag();
				TextView tv=(TextView)holder.symbol;
//				PriceActivity.this.debug(tv.getText());
			}
					});
		
	}

	private void Loop() {
//		((ImageView) this.findViewById(R.id.loadingImg)).setVisibility(1);
		try {
			new PriceParser() {
				// 重写了PriceParser里的handleMessage
				@Override
				public boolean handleMessage(Message msg) {
					if(msg.what==200){
						onParseSuccess(msg.obj);
					}else if(msg.what==403){
						onParseFailed("目前无行情数据");
						Urls.SwitchSite();
					}else{
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

	public void onPriceChanged(List<PriceBean> paramList) {
		this.priceAdapter.setData(paramList);
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
		ArrayList<PriceBean> list = (ArrayList<PriceBean>) obj;
		this.priceAdapter.setData(list);
		hideLoadingDialog();
	}
	// 取数据失败的回调
	public void onParseFailed(String s) {
		hideLoadingDialog();
		Toast.makeText(this, s, Toast.LENGTH_SHORT).show();
		// timer.notify();
	}
	// 取数据失败的回调
	public void onParseFailed(int i) {
		hideLoadingDialog();
		Toast.makeText(this, i, Toast.LENGTH_SHORT).show();
	}

	public PriceActivity() {
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
				priceAdapter.notifyAnimatedDataSetChanged(true);
			}
		};
	}

	private final Runnable hideDialog;
	private ProgressDialog loadingDialog;
	private final Runnable notifyDataChanged;

	public void showLoadingDialog() {
		if (this.loadingDialog == null) {
			this.loadingDialog = DialogFactory.showProgressDialog(this,
					R.string.loading_price_titile,
					R.string.loading_price_please_wait);
		} else {
			this.loadingDialog.show();
		}
	}
	
	public void debug(int s){
		Toast.makeText(this, s, Toast.LENGTH_SHORT).show();
	}
	public void debug(String s){
		Toast.makeText(this, s, Toast.LENGTH_SHORT).show();
	}
	public void debug(CharSequence s){
		Toast.makeText(this, s, Toast.LENGTH_SHORT).show();
	}

	public void hideLoadingDialog() {
		Runnable localRunnable = this.hideDialog;
		runOnUiThread(localRunnable);
		// ((ImageView)
		// this.findViewById(R.id.loadingImg)).setBackgroundResource(R.drawable.rates_trend_down);
//		((ImageView) this.findViewById(R.id.loadingImg)).setVisibility(0);
	}
	
	@Override
	public void onConfigurationChanged(Configuration config) {
	    super.onConfigurationChanged(config);
	}
}