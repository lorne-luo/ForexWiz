package com.leostudio.forexwiz.price;

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

public class PriceAdapter extends BaseAdapter implements View.OnClickListener,
		View.OnTouchListener {
	private final PriceActivity context;
	private List<PriceBean> prices;
	private int selected;
	private boolean shouldAnimate;
	private AtomicBoolean userIsClicking;
	private PriceParser priceParser;
	private int layoutId = R.layout.price_listitem;

	public PriceAdapter(PriceActivity paramRatesActivity, PriceParser pp) {
		priceParser = pp;
		ArrayList localArrayList = new ArrayList(0);
		this.prices = localArrayList;
		this.selected = 0;
		this.shouldAnimate = true;
		AtomicBoolean localAtomicBoolean = new AtomicBoolean(false);
		this.userIsClicking = localAtomicBoolean;
		this.context = paramRatesActivity;
	}

	@Override
	public int getCount() {
		return this.prices.size();
	}

	public Object getItem(int paramInt) {
		return this.prices.get(paramInt);
	}

	public long getItemId(int paramInt) {
		return paramInt;
	}

	public ArrayList<PriceBean> getPrices() {
		return (ArrayList) this.prices;
	}

	public final class ViewHolder {
		public ImageView direction;
		public TextView symbol;
		public TextView bid;
		public TextView ask;
	}

	@Override
	public View getView(int position, View convertView, ViewGroup parent) {
		ViewHolder holder = null;
		if (convertView == null) {
			holder = new ViewHolder();
			convertView = LayoutInflater.from(context).inflate(
					R.layout.price_listitem, null);
			holder.direction = (ImageView) convertView
					.findViewById(R.id.price_listitem_arrow);
			holder.symbol = (TextView) convertView
					.findViewById(R.id.price_symbol);
			holder.bid = (TextView) convertView.findViewById(R.id.price_bid);
			holder.ask = (TextView) convertView.findViewById(R.id.price_ask);
			convertView.setTag(holder);
		} else {
			holder = (ViewHolder) convertView.getTag();
		}
		if (Integer.valueOf(prices.get(position).getDirection()) == 1) {
			holder.direction.setBackgroundResource(R.drawable.rates_trend_up);
			holder.ask.setTextColor(Color.RED);
			holder.bid.setTextColor(Color.RED);
		} else if (Integer.valueOf(prices.get(position).getDirection()) == -1) {
			holder.direction.setBackgroundResource(R.drawable.rates_trend_down);
			holder.ask.setTextColor(Color.GREEN);
			holder.bid.setTextColor(Color.GREEN);
		}else{
			holder.direction.setBackgroundResource(R.color.background);
			holder.ask.setTextColor(Color.WHITE);
			holder.bid.setTextColor(Color.WHITE);
		}
		holder.bid.setText(prices.get(position).getBid());
		holder.ask.setText(prices.get(position).getAsk());
		holder.symbol.setText(prices.get(position).getSymbol());
		if(position%2==0)
			convertView.setBackgroundColor(Color.rgb(30, 30, 30));
		else {
			convertView.setBackgroundColor(Color.rgb(0, 0, 0));
		}
		// holder.viewBtn.setOnClickListener(new View.OnClickListener() {
		//
		// @Override
		// public void onClick(View v) {
		// showInfo();
		// }
		// });
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

	public void resetPriceChanges() {

	}

	public void resetPrices() {
		this.prices.clear();
		notifyAnimatedDataSetChanged(true);
	}

	public void setData(List<PriceBean> list) {
		prices = list;
		notifyDataSetChanged();
	}

	public boolean shouldAnimateLayout() {
		return this.shouldAnimate;
	}
}
