package com.leostudio.forexwiz.event;

public class EventBean {
	private String time;
	private String currency;
	private String content;
	
	public String getTime() {
		return time;
	}

	public void setTime(String time) {
		this.time = time;
	}

	public String getCurrency() {
		return currency;
	}

	public void setCurrency(String currency) {
		this.currency = currency;
	}

	public String getContent() {
		return content;
	}

	public void setContent(String content) {
		this.content = content;
	}

	public EventBean(String t, String c, String c2) {
		this.time = t;
		this.currency = c;
		this.content = c2;

	}
}
