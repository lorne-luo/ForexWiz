package com.leostudio.forexwiz.price;

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

import com.leostudio.forexwiz.R;
import com.leostudio.forexwiz.Urls;

import android.os.AsyncTask;
import android.os.Message;
import android.util.Log;
import android.widget.Toast;

public class PriceParser extends
		AsyncTask<PriceActivity, Void, List<PriceBean>> {
	private PriceActivity tActivity;
	private Message msg = new Message();
	private int statusCode;

	@SuppressWarnings("unchecked")
	@Override
	protected List<PriceBean> doInBackground(PriceActivity... activities) {
		// TODO Auto-generated method stub
		tActivity = activities[0];
		// Map<���ұ�ʶ, CurrencyBean>
		List<PriceBean> result = new ArrayList<PriceBean>();
		HttpParams  httpParameters = new BasicHttpParams();
		HttpConnectionParams.setConnectionTimeout(httpParameters, 9000);
		HttpConnectionParams.setSoTimeout(httpParameters, 9500);
		DefaultHttpClient httpClient = new DefaultHttpClient(httpParameters);
		HttpGet httpGet = new HttpGet(Urls.getPrice());
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
					content.append(line);// һ��һ�ж�ȡ
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
		if (s.length() > 2) {
			String[] linearr = s.split("\n");
			for (int i = 0; i < linearr.length; i++) {
				String[] itemarr = linearr[i].split(",");
				PriceBean cb = new PriceBean(itemarr[0], itemarr[1],
						itemarr[2], itemarr[3], itemarr[4], itemarr[5],
						itemarr[6]);
				result.add(cb);
			}
		} else {
			statusCode = 403;
		}
		return result;
	}

	@Override
	protected void onPostExecute(List<PriceBean> result) {
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
