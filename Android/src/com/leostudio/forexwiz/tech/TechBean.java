package com.leostudio.forexwiz.tech;

/**
 * »υ±ÒΚµΜε bid ask high low diretion time
 */
public class TechBean {
	private String title;
	private String content;
	private String up;
	private String down;

	public TechBean(String t,String c, String u, String d) {
		this.title = t;
		this.content=c;
		this.up = u;
		this.down = d;
	}

	public String getContent() {
		return content;
	}

	public void setContent(String content) {
		this.content = content;
	}
	
	public String getTitle() {
		return title;
	}

	public void setTitle(String title) {
		this.title = title;
	}

	public String getUp() {
		return up;
	}

	public void setUp(String up) {
		this.up = up;
	}

	public String getDown() {
		return down;
	}

	public void setDown(String down) {
		this.down = down;
	}
}
