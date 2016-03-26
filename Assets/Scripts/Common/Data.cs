using UnityEngine;
using System;
using System.Collections;

public class DataKey {

	public static string TimerState = "TimerState";
	public static string TimerBeginDate = "TimerBeginDate";
}

public class Data {

	public static bool TimerState; // on = true; off = false
}

public class DataContent {

	public static void SetTimerIsOn (bool isOn)
	{
		// TODO
	}

	public static bool GetTimerState ()
	{
		// TODO

		return false;
	}

	public static DateTime GetPassedWorkTime ()
	{
		// TODO

		DateTime dateTime = new DateTime ();

		return dateTime;
	}

	public static DateTime GetNowTime ()
	{
		// TODO

		DateTime dateTime = new DateTime ();

		return dateTime;
	}
}