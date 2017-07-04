package com.leostudio.forexwiz.event;

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
import com.leostudio.util.DialogFactory;

import android.R.integer;
import android.app.Activity;
import android.app.AlertDialog;
import android.app.ListActivity;
import android.app.ProgressDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.res.Configuration;
import android.os.Bundle;
import android.os.Message;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.SimpleAdapter.ViewBinder;

import com.mobclick.android.MobclickAgent;

public class EventActivity extends Activity implements View.OnClickListener {
	private EventAdapter eventAdapter;
	private ListView eventListView;
	private int loopInterval = 15000;
	private static EventCalendar eventCalendar;
	private CheckBox cbLow;
	private CheckBox cbMedium;
	private CheckBox cbHigh;
	private static int day;

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.event_main);
		
		Calendar cal = Calendar.getInstance();
		int day = cal.get(Calendar.DATE);
		int month = cal.get(Calendar.MONTH) + 1;
		((TextView) findViewById(R.id.header)).setText(getString(R.string.event)+" "+month+"月"+day+"日");
		
		this.eventListView = (ListView) findViewById(R.id.event_list);
		this.eventAdapter = new EventAdapter(this, new EventParser());
		this.eventListView.setAdapter(eventAdapter);

		if (EventActivity.day != day) {// 日期不一致
			Request();
			showLoadingDialog();
		} else {
			this.eventAdapter.setData(eventCalendar);
		}
		cbLow = ((CheckBox) findViewById(R.id.low));
		cbLow.setOnClickListener(this);
		cbMedium = ((CheckBox) findViewById(R.id.medium));
		cbMedium.setOnClickListener(this);
		cbHigh = ((CheckBox) findViewById(R.id.high));
		cbHigh.setOnClickListener(this);

	}

	private void Request() {
		try {
			new EventParser() {
				// 重写了Parser里的handleMessage
				@Override
				public boolean handleMessage(Message msg) {
					if (msg.what == 200) {
						onParseSuccess(msg.obj);
					} else if (msg.what == 403) {
						onParseFailed("今日无财经事件");
						// onParseFailed(String.valueOf(((EventCalendar)msg.obj).size()));
					} else {
						onParseFailed(msg.what);
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

	public void onEventChanged(EventCalendar paramList) {
		this.eventAdapter.setData(paramList);
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
		MobclickAgent.onPause(this);
	}

	@Override
	protected void onResume() {
		super.onResume();
		MobclickAgent.onResume(this);
	}

	// 取数据成功的回调
	public void onParseSuccess(Object obj) {
		eventCalendar = (EventCalendar) obj;
		if (obj instanceof EventCalendar) {
			this.eventAdapter.setData(eventCalendar);
			Calendar cal = Calendar.getInstance();
			EventActivity.day = cal.get(Calendar.DATE);
		}
		hideLoadingDialog();
	}

	// 取数据失败的回调
	public void onParseFailed(Object obj) {
		hideLoadingDialog();
		// Toast.makeText(this, R.string.loading_failed,
		// Toast.LENGTH_SHORT).show();
		Toast.makeText(this, String.valueOf(obj), Toast.LENGTH_SHORT).show();
		// timer.notify();
	}

	public EventActivity() {
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
				eventAdapter.notifyAnimatedDataSetChanged(true);
			}
		};
	}

	private final Runnable hideDialog;
	private ProgressDialog loadingDialog;
	private final Runnable notifyDataChanged;

	public void showLoadingDialog() {
		if (this.loadingDialog == null) {
			this.loadingDialog = DialogFactory.showProgressDialog(this,
					R.string.loading_event_titile,
					R.string.loading_event_please_wait);
		} else {
			this.loadingDialog.show();
		}
	}

	public void ToastShow(String s) {
		Toast.makeText(this, s, Toast.LENGTH_SHORT).show();
	}

	public void hideLoadingDialog() {
		Runnable localRunnable = this.hideDialog;
		runOnUiThread(localRunnable);
		// ((ImageView)
		// this.findViewById(R.id.loadingImg)).setBackgroundResource(R.drawable.event_trend_down);
		// ((ImageView) this.findViewById(R.id.loadingImg)).setVisibility(0);
	}

	public void onEventClick(View v) {
		// TODO Auto-generated method stub
		Object obj = this.eventAdapter.events.get(v.getId());
		String title = null;
		String content = null;
		if (obj instanceof EventBean) {
			if (((EventBean) obj).getTime() == "财经事件") {
				return;
			}
			title = ((EventBean) obj).getTime();
			content = ((EventBean) obj).getContent();
		} else {
			if (((CalendarBean) obj).getTime() == "财经数据") {
				return;
			}
			title = ((CalendarBean) obj).getTime();
			content = ((CalendarBean) obj).getTitle();
			content += ((CalendarBean) obj).getDescription().length() <= 0 ? ""
					: "\n" + ((CalendarBean) obj).getDescription();
			content += "\n前值：" + ((CalendarBean) obj).getBefore() + "\n预测："
					+ ((CalendarBean) obj).getAfter() + "\n重要性："
					+ ((CalendarBean) obj).getImportance();
		}
		AlertDialog.Builder builder = new AlertDialog.Builder(this).setTitle(
				title).setIcon(android.R.drawable.btn_star).setMessage(content)
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

	@Override
	public void onClick(View v) {
		switch (v.getId()) {
		case R.id.low:
			setImportance();
			break;
		case R.id.medium:
			setImportance();
			break;
		case R.id.high:
			setImportance();
			break;
		default:
			break;
		}
	}

	public void setImportance() {
		EventCalendar temp = new EventCalendar();
		temp.eventList = eventCalendar.eventList;
		temp.calendarList = new ArrayList<CalendarBean>();
		for (int i = 0; i < eventCalendar.calendarList.size(); i++) {
			CalendarBean cb = eventCalendar.calendarList.get(i);
			if (cb.getTime().equals("财经数据")) {
				temp.calendarList.add(cb);
			} else if (cb.getImportance().equals("低") && cbLow.isChecked()) {
				temp.calendarList.add(cb);
			} else if (cb.getImportance().equals("中") && cbMedium.isChecked()) {
				temp.calendarList.add(cb);
			} else if (cb.getImportance().equals("高") && cbHigh.isChecked()) {
				temp.calendarList.add(cb);
			}
		}

		this.eventAdapter.setData(temp);
	}

	@Override
	public void onConfigurationChanged(Configuration config) {
		super.onConfigurationChanged(config);
	}
}