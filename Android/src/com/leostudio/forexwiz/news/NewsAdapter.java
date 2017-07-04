package com.leostudio.forexwiz.news;

import android.content.Intent;
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
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.atomic.AtomicBoolean;

import com.leostudio.forexwiz.R;
import com.leostudio.forexwiz.tech.TechAdapter.ViewHolder;

public class NewsAdapter extends BaseAdapter implements View.OnClickListener,
		View.OnTouchListener {
	private final NewsActivity context;
	private List<NewsBean> news;
	private int selected;
	private boolean shouldAnimate;
	private AtomicBoolean userIsClicking;
	private NewsParser newsParser;

	public NewsAdapter(NewsActivity paramRatesActivity, NewsParser pp) {
		newsParser = pp;
		ArrayList localArrayList = new ArrayList(0);
		this.news = localArrayList;
		this.selected = 0;
		this.shouldAnimate = true;
		AtomicBoolean localAtomicBoolean = new AtomicBoolean(false);
		this.userIsClicking = localAtomicBoolean;
		this.context = paramRatesActivity;
	}

	@Override
	public int getCount() {
		return this.news.size();
	}

	public Object getItem(int paramInt) {
		return this.news.get(paramInt);
	}

	public long getItemId(int paramInt) {
		return paramInt;
	}

	public ArrayList<NewsBean> getnews() {
		return (ArrayList) this.news;
	}

	public final class ViewHolder {
		// public ImageView img;
		public TextView title;
		public TextView time;
	}

	@Override
	public View getView(int position, View convertView, ViewGroup parent) {
		ViewHolder holder = null;
		holder = new ViewHolder();
		if (convertView == null) {
			convertView = LayoutInflater.from(context).inflate(
					R.layout.news_listitem, null);
			// holder.img = (ImageView)
			// convertView.findViewById(R.id.news_item_img);
			holder.title = (TextView) convertView
					.findViewById(R.id.news_item_title);
			holder.time = (TextView) convertView
					.findViewById(R.id.news_item_time);
			convertView.setTag(holder);
		} else {
			holder = (ViewHolder) convertView.getTag();
		}
		convertView.setId(position);
		holder.time.setText(news.get(position).getTime());
		holder.title.setText(news.get(position).getTitle());
		if (position % 2 == 0) {
			convertView.setBackgroundColor(Color.rgb(30, 30, 30));
		} else {
			convertView.setBackgroundColor(Color.rgb(0, 0, 0));
		}
		convertView.setOnClickListener(new View.OnClickListener() {

			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				context.onNewsClick(arg0);
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

	public void resetNewsChanges() {

	}

	public void resetNews() {
		this.news.clear();
		notifyAnimatedDataSetChanged(true);
	}

	public void setData(List<NewsBean> list) {
		news = list;
		notifyDataSetChanged();
	}

	public boolean shouldAnimateLayout() {
		return this.shouldAnimate;
	}
}
