package com.leostudio.forexwiz.event;

public class CalendarBean {
	private String time;
	private String title;
	private String description;
	private String before;
	private String after;
	private String importance;

	public CalendarBean(String t, String t2, String d, String b, String a,
			String i) {
		this.time = t;
		this.title = t2;
		this.description = d;
		this.before = b;
		this.after = a;
		this.importance = i;

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

	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public String getBefore() {
		return before;
	}

	public void setBefore(String before) {
		this.before = before;
	}

	public String getAfter() {
		return after;
	}

	public void setAfter(String after) {
		this.after = after;
	}

	public String getImportance() {
		return importance;
	}

	public void setImportance(String importance) {
		this.importance = importance;
	}

	public enum Importance {
		Low, Medium, High
	}
}
