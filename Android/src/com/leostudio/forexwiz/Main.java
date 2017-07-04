package com.leostudio.forexwiz;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Date;

import net.youmi.android.AdManager;

import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;

import com.leostudio.forexwiz.event.EventActivity;
import com.leostudio.forexwiz.news.NewsActivity;
import com.leostudio.forexwiz.price.List14;
import com.leostudio.forexwiz.price.PriceActivity;
import com.leostudio.forexwiz.price.PriceParser;
import com.leostudio.forexwiz.tech.TechActivity;

import android.app.Activity;
import android.app.AlertDialog;
import android.os.Bundle;
import android.os.Message;
import android.text.Html;
import android.text.method.LinkMovementMethod;
import android.text.util.Linkify;
import android.util.DisplayMetrics;
import android.view.Gravity;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.pm.PackageManager.NameNotFoundException;
import android.graphics.Color;
import com.mobclick.android.MobclickAgent;
import com.mobclick.android.ReportPolicy;
import com.mobclick.android.UmengFeedbackListener;

public class Main extends Activity {

	public static int WidthPixels;
	public static int HeightPixels;
	public static WindowManager Window;
	private static int exitTime;

	static {
		AdManager.init("b497b3501f70a10d", "7aabb34943753b6d", 30, false, 2.2);
	}

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);
		addMenuListeners();
		GetDisplayMetrics();
		MobclickAgent.setUpdateOnlyWifi(false);
		MobclickAgent.update(this);
		MobclickAgent.setReportPolicy(ReportPolicy.REALTIME);
		MobclickAgent.setFeedbackListener(new UmengFeedbackListener() {
			public void onFeedbackReturned(int arg0) {
				switch (arg0) {
				case 0:
					Toast.makeText(Main.this, "�����ɹ�", Toast.LENGTH_SHORT)
							.show();
					break;
				case 1:
					Toast.makeText(Main.this, "����ʧ��", Toast.LENGTH_SHORT)
							.show();
					break;
				case 2:
					Toast.makeText(Main.this, "����ʧ�ܣ�����������", Toast.LENGTH_SHORT)
							.show();
					break;
				}
			}
		});
	}

	@Override
	protected void onPause() {
		// TODO Auto-generated method stub
		super.onPause();
		this.exitTime = 0;
		MobclickAgent.onPause(this);
	}

	@Override
	protected void onResume() {
		super.onResume();
		this.exitTime = 0;
		MobclickAgent.onResume(this);
	}

	// �汾����
	protected void NotifyUpdate(String ver, String msg) {
		String htmlLinkText = msg + "<br/>���� " + "<a href=\""
				+ Urls.getUpdate() + "\">��  ��</a> ���ظ��»����Ӧ���г�����������мҡ�";
		AlertDialog.Builder builder = new AlertDialog.Builder(Main.this)
				.setTitle("�汾����").setIcon(android.R.drawable.ic_dialog_info)
				.setNegativeButton("ȷ     ��",
						new DialogInterface.OnClickListener() {
							@Override
							public void onClick(DialogInterface dialog,
									int which) {
							}
						});
		builder.create();

		TextView textView = new TextView(this);
		textView.setPadding(18, 18, 18, 18);
		textView.setText(Html.fromHtml(htmlLinkText));
		textView.setMovementMethod(LinkMovementMethod.getInstance());
		textView.setTextColor(getResources().getColor(R.color.text));
		textView.setTextSize(18);

		builder.setView(textView);
		builder.show();
	}

	private void addMenuListeners() {
		// ��ʱ�۸�
		((Button) findViewById(R.id.menu_price))
				.setOnClickListener(new View.OnClickListener() {
					public void onClick(View v) {
						Main.this.exitTime = 0;
						Bundle bundle = new Bundle();
						bundle.putString("key", "menu_price");
						Intent intent = new Intent();
						intent.putExtras(bundle);
						intent.setClass(Main.this, PriceActivity.class);
						startActivity(intent);
					}
				});
		// ��������
		((Button) findViewById(R.id.menu_news))
				.setOnClickListener(new View.OnClickListener() {
					public void onClick(View v) {
						Main.this.exitTime = 0;
						Intent intent = new Intent();
						intent.setClass(Main.this, NewsActivity.class);
						startActivity(intent);
					}
				});
		// ��������
		((Button) findViewById(R.id.menu_tech))
				.setOnClickListener(new View.OnClickListener() {
					public void onClick(View v) {
						Main.this.exitTime = 0;
						Intent intent = new Intent();
						intent.setClass(Main.this, TechActivity.class);
						startActivity(intent);
					}
				});
		// �ƾ��¼�
		((Button) findViewById(R.id.menu_event))
				.setOnClickListener(new View.OnClickListener() {
					public void onClick(View v) {
						Intent intent = new Intent();
						intent.setClass(Main.this, EventActivity.class);
						startActivity(intent);
					}
				});

		// ����
		((Button) findViewById(R.id.menu_about))
				.setOnClickListener(new View.OnClickListener() {
					public void onClick(View v) {
						Main.this.exitTime = 0;
						AlertDialog.Builder builder = new AlertDialog.Builder(
								Main.this).setTitle(
								getString(R.string.app_name) + " v"
										+ getString(R.string.app_ver)).setIcon(
								android.R.drawable.ic_dialog_info)
								.setNegativeButton("�� ��",
										new DialogInterface.OnClickListener() {
											@Override
											public void onClick(
													DialogInterface dialog,
													int which) {
											}
										}).setPositiveButton("�� ��",
										new DialogInterface.OnClickListener() {
											@Override
											public void onClick(
													DialogInterface dialog,
													int which) {
												MobclickAgent
														.openFeedbackActivity(Main.this);
											}
										});
						builder.create();
						TextView textView = new TextView(Main.this);
						textView.setPadding(18, 18, 18, 18);
						textView.setText(Html
								.fromHtml(getString(R.string.app_about)));
						textView.setMovementMethod(LinkMovementMethod
								.getInstance());
						textView.setTextColor(getResources().getColor(
								R.color.text));
						textView.setTextSize(18);
						builder.setView(textView);
						builder.show();
					}
				});

		// ����
		((Button) findViewById(R.id.menu_setting))
				.setOnClickListener(new View.OnClickListener() {
					public void onClick(View v) {
						Main.this.exitTime = 0;
						Toast.makeText(Main.this, "������������ע����мҺ����汾",
								Toast.LENGTH_SHORT).show();
					}
				});

		MenuQuitListener quitListener = new MenuQuitListener();
		((Button) findViewById(R.id.menu_quit))
				.setOnClickListener(quitListener);
	}

	// ��ȡ��Ļ�ֱ���
	private void GetDisplayMetrics() {
		DisplayMetrics displaysMetrics = new DisplayMetrics();
		getWindowManager().getDefaultDisplay().getMetrics(displaysMetrics);
		WidthPixels = displaysMetrics.widthPixels;
		HeightPixels = displaysMetrics.heightPixels;
		Window = (WindowManager) getApplicationContext().getSystemService(
				"window");
	}

	@Override
	public boolean onKeyDown(int paramInt, KeyEvent paramKeyEvent) {
		if ((paramInt == KeyEvent.KEYCODE_BACK)
				&& (paramKeyEvent.getRepeatCount() == 0)) {
			Quit();
			return true;
		}
		this.exitTime = 0;
		if ((paramInt == KeyEvent.KEYCODE_MENU)
				&& (paramKeyEvent.getRepeatCount() == 0))
			openOptionsMenu();
		return true;
	}

	protected void Quit() {
		this.exitTime++;
		if (this.exitTime == 1) {
			Toast toast = Toast.makeText(this, "�ٴε�����˳�", Toast.LENGTH_LONG);
			toast.show();
		}

		if (this.exitTime > 1) {
			this.exitTime = 0;
			// System.exit(0);
			finish();
		}
	}

	// ----------------------------------------------
	// �˵��˳�
	class MenuQuitListener implements View.OnClickListener {
		public void onClick(View paramView) {
			// new AlertDialog.Builder(Main.this).setTitle("ȷ���˳�").setIcon(
			// android.R.drawable.ic_dialog_info).setMessage("ȷ��Ҫ�˳�ô��")
			// .setNegativeButton("ȡ  ��",
			// new DialogInterface.OnClickListener() {
			// @Override
			// public void onClick(DialogInterface dialog,
			// int which) {
			// }
			// }).setPositiveButton("ȷ ��",
			// new DialogInterface.OnClickListener() {
			// @Override
			// public void onClick(DialogInterface dialog,
			// int which) {
			// System.exit(0);
			// }
			// }).show();
			Quit();
		}
	}

}
