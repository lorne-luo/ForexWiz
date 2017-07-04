package com.leostudio.forexwiz.tech;

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

public class TechAdapter extends BaseAdapter implements View.OnClickListener,
		View.OnTouchListener {
	private final TechActivity context;
	private List<TechBean> techs;
	private int selected;
	private boolean shouldAnimate;
	private AtomicBoolean userIsClicking;
	private TechParser techParser;
	private int layoutId = R.layout.tech_listitem;

	public TechAdapter(TechActivity paramActivity, TechParser pp) {
		techParser = pp;
		ArrayList localArrayList = new ArrayList(0);
		this.techs = localArrayList;
		this.selected = 0;
		this.shouldAnimate = true;
		AtomicBoolean localAtomicBoolean = new AtomicBoolean(false);
		this.userIsClicking = localAtomicBoolean;
		this.context = paramActivity;
	}

	@Override
	public int getCount() {
		return this.techs.size();
	}

	public Object getItem(int paramInt) {
		return this.techs.get(paramInt);
	}

	public long getItemId(int paramInt) {
		return paramInt;
	}

	public ArrayList<TechBean> gettechs() {
		return (ArrayList) this.techs;
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
					R.layout.tech_listitem, null);
			holder.title = (TextView) convertView.findViewById(R.id.tech_title);
			holder.content = (TextView) convertView.findViewById(R.id.tech_content);
			convertView.setTag(holder);
		} else {
			holder = (ViewHolder) convertView.getTag();
		}
		convertView.setId(position);
		holder.title.setText(techs.get(position).getTitle());
		holder.content.setText(techs.get(position).getContent());
		if(position%2==0)
			convertView.setBackgroundColor(Color.rgb(30, 30, 30));
		else {
			convertView.setBackgroundColor(Color.rgb(0, 0, 0));
		}
		convertView.setOnClickListener(new View.OnClickListener() {
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				context.onTechClick(arg0);
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
	
		return false;
	}

	public void resetTechsChanges() {
		
	}

	public void resetTechs() {
		this.techs.clear();
		notifyAnimatedDataSetChanged(true);
	}

	public void setData(List<TechBean> list) {
		techs = list;
		notifyDataSetChanged();
	}

	public boolean shouldAnimateLayout() {
		return this.shouldAnimate;
	}
}
