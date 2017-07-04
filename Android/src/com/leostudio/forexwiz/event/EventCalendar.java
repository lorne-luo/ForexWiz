package com.leostudio.forexwiz.event;

import java.util.ArrayList;
import java.util.List;

public class EventCalendar {
	public List<EventBean> eventList = new ArrayList<EventBean>();
	public List<CalendarBean> calendarList = new ArrayList<CalendarBean>();;

	public int size() {
		// TODO Auto-generated method stub
		return eventList.size() + calendarList.size();
	}

	public Object get(int paramInt) {
		if (paramInt < eventList.size()) {
			return eventList.get(paramInt);
		}else {
			return calendarList.get(paramInt - eventList.size());
		}
	}

	public void clear() {
		eventList.clear();
		calendarList.clear();
	}

}
