package com.leostudio.forexwiz;

public class Urls {
	private static int baseSiteNo = 0;
	private static String baseSite3 = "http://forexwiz.sinaapp.com/";
	private static String baseSite1 = "http://leandro.132.china123.net/android/forexwiz/";
	private static String baseSite2 = "http://www.luotao.net/forexwiz/";

	private static final String Price = "data/price.php?type=csv";
	private static final String News = "data/news.php?type=csv";
	private static final String Tech = "data/tech.php?type=csv";
	private static final String Calendar = "data/calendar_mem.php";

	private static final String Update = "android/ForexWiz.apk";
	private static final String Site = "";
	private static final String LastVersion = "android/version.txt";

	public static String getPrice() {
		if (baseSiteNo == 0)
			return baseSite1 + Price;
		else if (baseSiteNo == 1)
			return baseSite2 + Price;
		else
			return baseSite3 + Price;
	}

	public static String getNews() {
		if (baseSiteNo == 0)
			return baseSite1 + News;
		else if (baseSiteNo == 1)
			return baseSite2 + News;
		else
			return baseSite3 + News;
	}

	public static String getTech() {
		if (baseSiteNo == 0)
			return baseSite1 + Tech;
		else if (baseSiteNo == 1)
			return baseSite2 + Tech;
		else
			return baseSite3 + Tech;
	}

	public static String getCalendar() {
		if (baseSiteNo == 0)
			return baseSite1 + Calendar;
		else if (baseSiteNo == 1)
			return baseSite2 + Calendar;
		else
			return baseSite3 + Calendar;
	}

	public static String getSite() {
		if (baseSiteNo == 0)
			return baseSite1 + Site;
		else if (baseSiteNo == 1)
			return baseSite2 + Site;
		else
			return baseSite3 + Site;
	}

	public static String getLastVersion() {
		if (baseSiteNo == 0)
			return baseSite1 + LastVersion;
		else if (baseSiteNo == 1)
			return baseSite2 + LastVersion;
		else
			return baseSite3 + LastVersion;
	}

	public static String getUpdate() {
		if (baseSiteNo == 0)
			return baseSite1 + Update;
		else if (baseSiteNo == 1)
			return baseSite2 + Update;
		else
			return baseSite3 + Update;
	}

	public static void SwitchSite() {
		baseSiteNo = (baseSiteNo + 1) % 2;
	}
}
