package com.leostudio.forexwiz.price;

import com.leostudio.forexwiz.R;

import android.content.Context;
import android.content.res.Resources;
import android.graphics.drawable.Drawable;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnTouchListener;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

public class PriceListItemView extends LinearLayout {
	private final ImageView arrow;
	private final Drawable arrow_down;
	private final TextView ask;
	private final TextView bid;
	private final LinearLayout bidDisplay;

	private final Context context;
	private int position;
	private final TextView symbol;

	public PriceListItemView(Context paramContext,
			PriceAdapter paramRatesAdapter) {
		super(paramContext);
		this.context = paramContext;
		View localView = inflate(this.context, R.id.price_listitem, this);

		TextView localTextView1 = (TextView) findViewById(2131296344);
		this.symbol = localTextView1;
		ImageView localImageView = (ImageView) findViewById(2131296346);
		this.arrow = localImageView;
		LinearLayout localLinearLayout1 = (LinearLayout) findViewById(2131296347);
		this.bidDisplay = localLinearLayout1;
		TextView localTextView2 = (TextView) findViewById(2131296349);
		this.bid = localTextView2;

		TextView localTextView5 = (TextView) findViewById(2131296354);
		this.ask = localTextView5;

		setId(2131296343);

		Drawable localDrawable2 = this.context.getResources().getDrawable(
				2130837550);
		this.arrow_down = localDrawable2;

	}

	public int getPosition() {
		return this.position;
	}

	public void setClickListeners(View.OnClickListener paramOnClickListener,
			View.OnTouchListener paramOnTouchListener) {
		setOnClickListener(paramOnClickListener);
		this.bidDisplay.setOnClickListener(paramOnClickListener);
		// this.askDisplay.setOnClickListener(paramOnClickListener);
		setOnTouchListener(paramOnTouchListener);
	}

	public void setPosition(int paramInt) {
		this.position = paramInt;
	}

	public void setPrice(PriceBean paramPrice) {
		this.symbol.setText(paramPrice.getSymbol());
		this.bid.setText(paramPrice.getBid());
		this.ask.setText(paramPrice.getAsk());

	}

	public void setSelected(boolean paramBoolean) {
		if (paramBoolean) {
			setBackgroundDrawable(this.context.getResources().getDrawable(
					R.drawable.rates_listitem_bg));
		} else {
			setBackgroundColor(R.color.background);
		}
	}
}
