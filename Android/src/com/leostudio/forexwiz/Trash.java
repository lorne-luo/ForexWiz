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

//自动更新
try {
			new Updater() {
				// 重写了PriceParser里的handleMessage
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
									// 更新
									NotifyUpdate(info[0], "");
								}
							} else if (info.length == 2) {
								float lastVer = Float.valueOf(String
										.valueOf(info[0]));
								float nowVer = Float.valueOf(getString(R.string.app_ver));
								String content = String.valueOf(info[1]);
								if (lastVer > nowVer) {
									// 更新
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
		
//		 这里的flags也很关键 代码实际是wmParams.flags |= FLAG_NOT_FOCUSABLE;
//		 40的由来是wmParams的默认属性（32）+ FLAG_NOT_FOCUSABLE（8）
		 
		wmParams.flags = 32;
		wmParams.type = 2002; // type是关键，这里的2002表示系统级窗口，你也可以试试2003。
		wmParams.format = 1;
		wmParams.width = Main.WidthPixels/10*9;
		wmParams.height = Main.HeightPixels / 5;
		// wm.addView(btnClose, wmParams);// 创建View
		Main.Window.addView(tvContent, wmParams);

		tvContent.setOnClickListener(new View.OnClickListener() {
			public void onClick(View v) {
				Main.Window.removeViewImmediate(v);
			}
		});
		
		
		
		
		.setPositiveButton("确 定",
						new DialogInterface.OnClickListener() {
							@Override
							public void onClick(DialogInterface dialog,
									int which) {
							}
						})
		
当用户点击手机设备上的“返回”按钮时，屏幕上的对话框将会被取消，如果你想让你的对话框不被取消掉的话，你可以如下设置你的对话框：
setCancelable(false);
AlertDialog字体大小设置
In Dialog.java (Android src) a ContextThemeWrapper is used. So you could copy the idea and do something like:
AlertDialog.Builder builder = new AlertDialog.Builder(new ContextThemeWrapper(this, R.style.AlertDialogCustom));
And then style it like you want:
<?xml version="1.0" encoding="utf-8"?><resources>    <style name="AlertDialogCustom" parent="@android:style/AlertDialog">        <item name="android:textColor">#00FF00</item>        <item name="android:typeface">monospace</item>        <item name="android:textSize">10sp</item>    </style></resources>



TextView textView = new TextView(this);
		textView.setPadding(16, 16, 16, 16);
		textView.setText(getResources().getString(R.string.app_name) + "已更新至"
				+ ver + "\n" + msg + "\n请访问：" + Html.fromHtml(htmlLinkText)
				+ "下载最新版本。");
		textView.setText(Html.fromHtml(htmlLinkText));

		textView.setMovementMethod(LinkMovementMethod.getInstance());
		textView.setTextColor(Color.WHITE);
		textView.setTextSize(16);
		
		TextView titleView = new TextView(this);
		titleView.setPadding(16, 16, 16, 16);
		titleView.setText("版本更新");
		titleView.setTextSize(16);
		builder.setIcon(android.R.drawable.btn_star);
		builder.setCustomTitle(titleView);
		
		builder.setView(textView);



*/