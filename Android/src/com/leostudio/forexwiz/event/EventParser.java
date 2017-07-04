package com.leostudio.forexwiz.event;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;

import com.leostudio.forexwiz.Urls;
import com.leostudio.forexwiz.news.NewsBean;
import com.leostudio.forexwiz.tech.TechBean;

import android.os.AsyncTask;
import android.os.Message;
import android.util.Log;
import android.widget.Toast;

public class EventParser extends AsyncTask<EventActivity, Void, EventCalendar> {
	private EventActivity tActivity;
	private Message msg = new Message();
	private int statusCode;

	@SuppressWarnings("unchecked")
	@Override
	protected EventCalendar doInBackground(EventActivity... activities) {
		// TODO Auto-generated method stub
		tActivity = activities[0];
		// Map<货币标识, CurrencyBean>
		EventCalendar result = new EventCalendar();
		DefaultHttpClient httpClient = new DefaultHttpClient();
		HttpGet httpGet = new HttpGet(Urls.getCalendar());
		StringBuffer content = new StringBuffer();
		try {
			HttpResponse response = httpClient.execute(httpGet);
			statusCode = response.getStatusLine().getStatusCode();
			if (statusCode == 200) {
				InputStream in = response.getEntity().getContent();

				BufferedReader br = new BufferedReader(new InputStreamReader(
						in, "utf-8"));
				String line = br.readLine();

				while (line != null) {
					content.append(line + "\n");// 一行一行读取
					line = br.readLine();
				}
				br.close();
				in.close();
			}
		} catch (ClientProtocolException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		} finally {
			httpClient.getConnectionManager().shutdown();
		}

		String s = content.toString();

		String[] grouparr = s.split("-\n");
		if (s.length() > 2 && grouparr.length > 1) {
			if (!grouparr[0].trim().equals("")) {// 有事件
				String[] linearr = grouparr[0].split("\n");
				for (int i = 0; i < linearr.length; i++) {
					String[] itemarr = linearr[i].split(",");
					EventBean cb = new EventBean(itemarr[1], itemarr[2],
							itemarr[3]);
					if (result.eventList.isEmpty()) {
						result.eventList.add(new EventBean("财经事件", "",
								"=====财经事件====="));
					}
					result.eventList.add(cb);
				}
			} else {// 无事件
				result.eventList.add(new EventBean("财经事件", "", "==今日无财经事件=="));
			}
			
			//有数据
			if (!grouparr[1].trim().equals("")) {
				String[] linearr2 = grouparr[1].split("\n");
				for (int i = 0; i < linearr2.length; i++) {
					String[] itemarr = linearr2[i].split(",");
					if (result.calendarList.isEmpty()) {
						result.calendarList.add(new CalendarBean("财经数据", "",
								"=====财经数据=====", "", "", ""));
					}
					CalendarBean cb = new CalendarBean(itemarr[0], itemarr[1],
							itemarr[2], itemarr[3], itemarr[4], itemarr[5]);
					result.calendarList.add(cb);
				}
			}else {//无数据
				result.calendarList.add(new CalendarBean("财经数据", "",
						"==今日无财经数据==", "", "", ""));
			}
			// String[] linearr = s.split("\n--\n");
			// for (int i = 1; i < linearr.length; i++) {
			// String[] itemarr = linearr[i].split("\n-\n");
			// TechBean cb = new TechBean(itemarr[0], itemarr[1], itemarr[2],
			// itemarr[2]);
			// result.add(cb);
			// }
		} else {
			statusCode = 403;
		}
		return result;
	}

	@Override
	protected void onPostExecute(EventCalendar result) {
		super.onPostExecute(result);
		msg.what = statusCode;
		msg.obj = result;
		handleMessage(msg);
		Log.v("EventParser", String.valueOf(msg.what));
	}

	public boolean handleMessage(Message msg) {
		// TODO Auto-generated method stub
		return false;
	}

}
