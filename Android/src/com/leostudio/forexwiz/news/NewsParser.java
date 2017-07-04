package com.leostudio.forexwiz.news;

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
import org.apache.http.params.BasicHttpParams;
import org.apache.http.params.HttpConnectionParams;
import org.apache.http.params.HttpParams;

import com.leostudio.forexwiz.Urls;

import android.os.AsyncTask;
import android.os.Message;
import android.util.Log;
import android.widget.Toast;

public class NewsParser extends AsyncTask<NewsActivity, Void, List<NewsBean>> {
	private NewsActivity tActivity;
	private Message msg = new Message();
	private int statusCode;

	@SuppressWarnings("unchecked")
	@Override
	protected List<NewsBean> doInBackground(NewsActivity... activities) {
		// TODO Auto-generated method stub
		tActivity = activities[0];
		// Map<货币标识, CurrencyBean>
		List<NewsBean> result = new ArrayList<NewsBean>();
		HttpParams  httpParameters = new BasicHttpParams();
		HttpConnectionParams.setConnectionTimeout(httpParameters, 9000);
		HttpConnectionParams.setSoTimeout(httpParameters, 9500);
		DefaultHttpClient httpClient = new DefaultHttpClient(httpParameters);
		HttpGet httpGet = new HttpGet(Urls.getNews()+"&id="+NewsActivity.last_id);
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
					if (content.length() > 0)
						content.append("\n");
					content.append(line);// 一行一行读取
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
		String[] linearr = s.split("\n");
		if (s.length() > 2) {
			for (int i = 0; i < linearr.length; i++) {
				String[] itemarr = linearr[i].split(",");
				NewsBean cb = new NewsBean(itemarr[0], itemarr[1], itemarr[2],
						itemarr[3], itemarr[4]);
				result.add(cb);
			}
		} else {
			statusCode = 403;
		}
		return result;
	}

	@Override
	protected void onPostExecute(List<NewsBean> result) {
		super.onPostExecute(result);

		msg.what = statusCode;
		msg.obj = result;
		handleMessage(msg);
		Log.v("PriceParser", String.valueOf(msg.what));
	}

	public boolean handleMessage(Message msg) {
		// TODO Auto-generated method stub
		return false;
	}

}
