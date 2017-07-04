package com.leostudio.forexwiz.price;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.leostudio.forexwiz.R;


public class EfficientAdapter extends BaseAdapter {
	private LayoutInflater mInflater;
	private Bitmap mIcon1;
	private Bitmap mIcon2;

	public EfficientAdapter(Context context) {
		// Cache the LayoutInflate to avoid asking for a new one each time.
		mInflater = LayoutInflater.from(context);

		// Icons bound to the rows.
		mIcon1 = BitmapFactory.decodeResource(context.getResources(),
				R.drawable.rates_trend_down);
		mIcon2 = BitmapFactory.decodeResource(context.getResources(),
				R.drawable.rates_trend_up);
	}

	/**
	 * The number of items in the list is determined by the number of
	 * speeches in our array.
	 * 
	 * @see android.widget.ListAdapter#getCount()
	 */
	public int getCount() {
		return DATA.length;
	}

	/**
	 * Since the data comes from an array, just returning the index is
	 * sufficent to get at the data. If we were using a more complex data
	 * structure, we would return whatever object represents one row in the
	 * list.
	 * 
	 * @see android.widget.ListAdapter#getItem(int)
	 */
	public Object getItem(int position) {
		return position;
	}

	/**
	 * Use the array index as a unique id.
	 * 
	 * @see android.widget.ListAdapter#getItemId(int)
	 */
	public long getItemId(int position) {
		return position;
	}

	/**
	 * Make a view to hold each row.
	 * 
	 * @see android.widget.ListAdapter#getView(int, android.view.View,
	 *      android.view.ViewGroup)
	 */
	public View getView(int position, View convertView, ViewGroup parent) {
		// A ViewHolder keeps references to children views to avoid
		// unneccessary calls
		// to findViewById() on each row.
		ViewHolder holder;

		// When convertView is not null, we can reuse it directly, there is
		// no need
		// to reinflate it. We only inflate a new View when the convertView
		// supplied
		// by ListView is null.
		if (convertView == null) {
			convertView = mInflater.inflate(R.layout.price_listitem, null);

			// Creates a ViewHolder and store references to the two children
			// views
			// we want to bind data to.
			holder = new ViewHolder();
			holder.bid = (TextView) convertView
					.findViewById(R.id.price_bid);
			holder.ask = (TextView) convertView
					.findViewById(R.id.price_ask);
			holder.symbol = (TextView) convertView
					.findViewById(R.id.price_symbol);
			holder.icon = (ImageView) convertView
					.findViewById(R.id.price_listitem_arrow);

			convertView.setTag(holder);
		} else {
			// Get the ViewHolder back to get fast access to the TextView
			// and the ImageView.
			holder = (ViewHolder) convertView.getTag();
		}

		// Bind the data efficiently with the holder.
		holder.bid.setText(DATA[position]);
		holder.ask.setText(DATA[0]);
		holder.symbol.setText(DATA[1]);
		holder.icon.setImageBitmap((position & 1) == 1 ? mIcon1 : mIcon2);

		return convertView;
	}

	static class ViewHolder {
		TextView ask;
		TextView bid;
		TextView symbol;
		ImageView icon;
	}
	public static String[] DATA = { "Abbaye de Belloc", "Abb" };
}
