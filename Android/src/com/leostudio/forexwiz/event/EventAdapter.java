package com.leostudio.forexwiz.event;

import android.content.Intent;
import android.content.res.ColorStateList;
import android.graphics.Color;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnTouchListener;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.atomic.AtomicBoolean;

import com.leostudio.forexwiz.R;

public class EventAdapter extends BaseAdapter implements View.OnClickListener,
		View.OnTouchListener {
	private final EventActivity context;
	public EventCalendar events;
	private int selected;
	private boolean shouldAnimate;
	private AtomicBoolean userIsClicking;
	private EventParser eventParser;
	private int layoutId = R.layout.event_listitem;
	private boolean isShowLow = true;
	private boolean isShowMedium = true;
	private boolean isShowHigh = true;

	public EventAdapter(EventActivity paramActivity, EventParser pp) {
		eventParser = pp;
		this.events = new EventCalendar();
		this.selected = 0;
		this.shouldAnimate = true;
		AtomicBoolean localAtomicBoolean = new AtomicBoolean(false);
		this.userIsClicking = localAtomicBoolean;
		this.context = paramActivity;
	}

	@Override
	public int getCount() {
		return this.events.size();
	}

	public long getItemId(int paramInt) {
		return paramInt;
	}

	public final class ViewHolder {
		public TextView title;
		public TextView content;
	}

	@Override
	public View getView(int position, View convertView, ViewGroup parent) {
		ViewHolder holder = null;
		if (convertView == null) {
			holder = new ViewHolder();
			convertView = LayoutInflater.from(context).inflate(
					R.layout.event_listitem, null);
			holder.title = (TextView) convertView
					.findViewById(R.id.event_title);
			holder.content = (TextView) convertView
					.findViewById(R.id.event_content);
			convertView.setTag(holder);
		} else {
			holder = (ViewHolder) convertView.getTag();
		}
		convertView.setId(position);
		Object obj = events.get(position);

		if (position % 2 == 0)
			convertView.setBackgroundColor(Color.rgb(30, 30, 30));
		else {
			convertView.setBackgroundColor(Color.rgb(0, 0, 0));
		}

		// 判断是event还是calendar
		if (obj instanceof EventBean) {
			EventBean eb = (EventBean) obj;
			if (eb.getTime().equals("财经事件")) {
				// holder.title.setTextSize(23);
				holder.title.setTextColor(Color.rgb(20, 20, 20));
				holder.content.setTextColor(Color.rgb(20, 20, 20));
				holder.title.setText("");
				//holder.title.setText(month + "月\n" + day + "日 ");
				holder.content.setText(eb.getContent());
				convertView.setBackgroundColor(Color.rgb(220, 220, 220));
				// holder.content.setVisibility(View.INVISIBLE);
			} else {
				holder.title.setTextColor(context.getResources().getColor(
						R.color.text));
				holder.content.setTextColor(context.getResources().getColor(
						R.color.text));
				holder.title.setText(eb.getTime());
				String content=eb.getCurrency()==""?eb.getContent():"["+eb.getCurrency()+"]"+eb.getContent();
				holder.content.setText(content);
			}
		} else {
			CalendarBean cb = (CalendarBean) obj;
			if (cb.getTime().equals("财经数据")) {
				// holder.title.setTextSize(23);
				holder.title.setTextColor(Color.rgb(20, 20, 20));
				holder.content.setTextColor(Color.rgb(20, 20, 20));
				holder.title.setText("");
				//holder.title.setText(month + "月\n" + day + "日 ");
				holder.content.setText(cb.getDescription());
				convertView.setBackgroundColor(Color.rgb(220, 220, 220));
			} else {
				holder.title.setTextColor(context.getResources().getColor(
						R.color.text));
				holder.content.setTextColor(context.getResources().getColor(
						R.color.text));
				holder.title.setText(cb.getTime());
				
				StringBuffer content = new StringBuffer();
				content.append(cb.getTitle()+"\n");
				if (!cb.getBefore().equals("")) {
					content.append("前值:" + cb.getBefore());
				}
				if (!cb.getAfter().equals("")) {
					content.append(" 预测值:" + cb.getAfter());
				}
				if (!cb.getImportance().equals("")) {
					content.append(" 重要性:" + cb.getImportance());
				}
				holder.content.setText(content.toString());
			}
		}

		convertView.setOnClickListener(new View.OnClickListener() {

			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				context.onEventClick(arg0);
			}
		});
		return convertView;
	}

	public void notifyAnimatedDataSetChanged(boolean paramBoolean) {
		this.shouldAnimate = paramBoolean;
		notifyDataSetChanged();
	}

	public void onClick(View paramView) {

	}

	public boolean onTouch(View paramView, MotionEvent paramMotionEvent) {
		// if (paramMotionEvent.getAction() == 0)
		// this.userIsClicking.set(1);
		// while (true) {
		// return false;
		// if ((paramMotionEvent.getAction() != 1)
		// && (paramMotionEvent.getAction() != 3))
		// continue;
		// this.userIsClicking.set(0);
		// }
		return false;
	}

	public void resetEventChanges() {

	}

	public void resetEvent() {
		this.events.clear();
		notifyAnimatedDataSetChanged(true);
	}

	public void setData(EventCalendar eventCalendar) {
		events = eventCalendar;
		notifyDataSetChanged();
	}

	public boolean shouldAnimateLayout() {
		return this.shouldAnimate;
	}

	@Override
	public Object getItem(int position) {
		return events.get(position);
	}
}
