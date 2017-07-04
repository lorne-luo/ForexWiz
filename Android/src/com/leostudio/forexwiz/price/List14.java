/*
 * Copyright (C) 2008 The Android Open Source Project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package com.leostudio.forexwiz.price;

import java.util.Timer;
import java.util.TimerTask;

import com.leostudio.forexwiz.R;

import android.app.ListActivity;
import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.View.OnClickListener;
import android.widget.BaseAdapter;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.ImageView;
import android.widget.Toast;
import android.graphics.BitmapFactory;
import android.graphics.Bitmap;

/**
 * Demonstrates how to write an efficient list adapter. The adapter used in this
 * example binds to an ImageView and to a TextView for each row in the list.
 * 
 * To work efficiently the adapter implemented here uses two techniques: - It
 * reuses the convertView passed to getView() to avoid inflating View when it is
 * not necessary - It uses the ViewHolder pattern to avoid calling
 * findViewById() when it is not necessary
 * 
 * The ViewHolder pattern consists in storing a data structure in the tag of the
 * view returned by getView(). This data structures contains references to the
 * views we want to bind data to, thus avoiding calls to findViewById() every
 * time getView() is invoked.
 */
public class List14 extends ListActivity {
	Timer timer;
	TimerTask task;

	

	EfficientAdapter ea = null;

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		ea = new EfficientAdapter(this);

		setListAdapter(ea);
		
		timer = new Timer();
		task = new TimerTask() {
			@Override
			public void run() {
				// TODO Auto-generated method stub
				runOnUiThread(new Runnable() {
					@Override
					public void run() {
						if (true) {
							ea.DATA = new String[] { "Abloc", String.valueOf(i++),
									"Abertam" };
							//Toast.makeText(List14.this, DATA[0],Toast.LENGTH_LONG).show();
							List14.this.ea.notifyDataSetChanged();
							b = true;
						}
					}
				});
			}
		};

		int period = 1*1000;
		timer.schedule(task, period, period);

	}

	@Override
	protected void onListItemClick(ListView l, View v, int position, long id) {
		ea.DATA = new String[] { "lloc", "1", "Abertam" };
		//Toast.makeText(List14.this, DATA[1], Toast.LENGTH_LONG).show();
		List14.this.ea.notifyDataSetChanged();

	}

	boolean b = false;
	int i=0;
	
}
