package com.leostudio.forexwiz;
import com.leostudio.forexwiz.R;

import android.content.DialogInterface;
import android.graphics.Color;
import android.os.Message;
import android.text.Html;
import android.text.method.LinkMovementMethod;
import android.widget.TextView;
import android.widget.Toast;


/*
private static final String url = "file:///android_asset/index.html";  

//�Զ�����
try {
			new Updater() {
				// ��д��PriceParser���handleMessage
				@Override
				public boolean handleMessage(Message msg) {

					if (msg.what == 200) {
						// onParseSuccess(msg.obj);
						String[] info = String.valueOf(msg.obj).split("\n", 2);
						try {
							String ver = getPackageManager().getPackageInfo(
									"com.leostudio.forexwiz", 0).versionName;
							if (info.length == 1) {
								float lastVer = Float.valueOf(String
										.valueOf(info[0]));
								float nowVer = Float.valueOf(getString(R.string.app_ver));
								if (lastVer > nowVer) {
									// ����
									NotifyUpdate(info[0], "");
								}
							} else if (info.length == 2) {
								float lastVer = Float.valueOf(String
										.valueOf(info[0]));
								float nowVer = Float.valueOf(getString(R.string.app_ver));
								String content = String.valueOf(info[1]);
								if (lastVer > nowVer) {
									// ����
									NotifyUpdate(info[0], info[1]);
								}
							}

						} catch (Exception e) {
						}

					} else if (msg.what > 400 && msg.what < 500) {
						Urls.SwitchSite();
					} else {
						Toast.makeText(Main.this, String.valueOf(msg.what),
								Toast.LENGTH_SHORT).show();
					}
					return false;
				}
			}.execute(this);
		} catch (Exception e) {
		}

TextView tvContent = new Button(getApplicationContext());
		tvContent.setText(news.get(v.getId()).getDetail());
		tvContent.setLinkTextColor(R.color.green);
		tvContent.setMovementMethod(LinkMovementMethod.getInstance());
		tvContent.setAutoLinkMask(Linkify.ALL);
		tvContent.setBackgroundColor(Color.GRAY);
		tvContent.setHighlightColor(Color.BLUE);
		tvContent.setTextColor(Color.WHITE);
		Button btnClose = new Button(getApplicationContext());
		btnClose.setText("Close");
		WindowManager.LayoutParams wmParams = new WindowManager.LayoutParams();
		
//		 �����flagsҲ�ܹؼ� ����ʵ����wmParams.flags |= FLAG_NOT_FOCUSABLE;
//		 40��������wmParams��Ĭ�����ԣ�32��+ FLAG_NOT_FOCUSABLE��8��
		 
		wmParams.flags = 32;
		wmParams.type = 2002; // type�ǹؼ��������2002��ʾϵͳ�����ڣ���Ҳ��������2003��
		wmParams.format = 1;
		wmParams.width = Main.WidthPixels/10*9;
		wmParams.height = Main.HeightPixels / 5;
		// wm.addView(btnClose, wmParams);// ����View
		Main.Window.addView(tvContent, wmParams);

		tvContent.setOnClickListener(new View.OnClickListener() {
			public void onClick(View v) {
				Main.Window.removeViewImmediate(v);
			}
		});
		
		
		
		
		.setPositiveButton("ȷ ��",
						new DialogInterface.OnClickListener() {
							@Override
							public void onClick(DialogInterface dialog,
									int which) {
							}
						})
		
���û�����ֻ��豸�ϵġ����ء���ťʱ����Ļ�ϵĶԻ��򽫻ᱻȡ���������������ĶԻ��򲻱�ȡ�����Ļ������������������ĶԻ���
setCancelable(false);
AlertDialog�����С����
In Dialog.java (Android src) a ContextThemeWrapper is used. So you could copy the idea and do something like:
AlertDialog.Builder builder = new AlertDialog.Builder(new ContextThemeWrapper(this, R.style.AlertDialogCustom));
And then style it like you want:
<?xml version="1.0" encoding="utf-8"?><resources>    <style name="AlertDialogCustom" parent="@android:style/AlertDialog">        <item name="android:textColor">#00FF00</item>        <item name="android:typeface">monospace</item>        <item name="android:textSize">10sp</item>    </style></resources>



TextView textView = new TextView(this);
		textView.setPadding(16, 16, 16, 16);
		textView.setText(getResources().getString(R.string.app_name) + "�Ѹ�����"
				+ ver + "\n" + msg + "\n����ʣ�" + Html.fromHtml(htmlLinkText)
				+ "�������°汾��");
		textView.setText(Html.fromHtml(htmlLinkText));

		textView.setMovementMethod(LinkMovementMethod.getInstance());
		textView.setTextColor(Color.WHITE);
		textView.setTextSize(16);
		
		TextView titleView = new TextView(this);
		titleView.setPadding(16, 16, 16, 16);
		titleView.setText("�汾����");
		titleView.setTextSize(16);
		builder.setIcon(android.R.drawable.btn_star);
		builder.setCustomTitle(titleView);
		
		builder.setView(textView);



*/