package push800.photograph.utils;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;

import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;

import android.os.Message;


public class Http {

	public static Message Requesst(String url) {
		Message msg = new Message();
		DefaultHttpClient httpClient = new DefaultHttpClient();
		HttpGet httpGet = new HttpGet(url);
		StringBuffer content = new StringBuffer();
		try {
			HttpResponse response = httpClient.execute(httpGet);
			msg.what = response.getStatusLine().getStatusCode();
			if (msg.what == 200) {
				InputStream in = response.getEntity().getContent();

				BufferedReader br = new BufferedReader(new InputStreamReader(
						in, "utf-8"));
				String line = br.readLine();

				while (line != null) {
					content.append(line + "\n");
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
		msg.obj = content.toString();
		return null;
	}
}
