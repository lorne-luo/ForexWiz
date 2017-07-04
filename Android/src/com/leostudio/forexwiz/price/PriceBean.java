package com.leostudio.forexwiz.price;

/**
 * »υ±ÒΚµΜε bid ask high low diretion time
 */
public class PriceBean {
	private String symbol;
	private String bid;
	private String ask;
	private String high;
	private String low;
	private String direction;
	private String time;

	public String getSymbol() {
		return symbol;
	}

	public void setSymbol(String symbol) {
		this.symbol = symbol;
	}

	public String getBid() {
		return bid;
	}

	public void setBid(String bid) {
		this.bid = bid;
	}

	public String getAsk() {
		return ask;
	}

	public void setAsk(String ask) {
		this.ask = ask;
	}

	public String getHigh() {
		return high;
	}

	public void setHigh(String high) {
		this.high = high;
	}

	public String getLow() {
		return low;
	}

	public void setLow(String low) {
		this.low = low;
	}

	public String getDirection() {
		return direction;
	}

	public void setDirection(String direction) {
		this.direction = direction;
	}

	public String getTime() {
		return time;
	}

	public void setTime(String time) {
		this.time = time;
	}

	public PriceBean(String s, String b, String a, String h, String l, String d, String t) {
		this.symbol = s;
		this.bid = b;
		this.ask = a;
		this.high = h;
		this.low = l;
		this.direction = d;
		this.time = t;
	}
}
