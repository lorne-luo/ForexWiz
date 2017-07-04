package com.leostudio.forexwiz.news;

/**
 * »υ±ÒΚµΜε bid ask high low diretion time
 */
public class NewsBean {
	private String id;
	private String date;
	private String time;
	private String title;
	private String content;


	public NewsBean(String i, String d, String t1, String t2, String c) {
		this.id = i;
		this.date = d;
		this.time = t1;
		this.title = t2;
		this.content = c;
	}


	public String getId() {
		return id;
	}


	public void setId(String id) {
		this.id = id;
	}


	public String getDate() {
		return date;
	}


	public void setDate(String date) {
		this.date = date;
	}


	public String getTime() {
		return time;
	}


	public void setTime(String time) {
		this.time = time;
	}


	public String getTitle() {
		return title;
	}


	public void setTitle(String title) {
		this.title = title;
	}


	public String getContent() {
		return content;
	}


	public void setDetail(String c) {
		this.content = c;
	}
}
