using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

public class CSVManager
{
	private static List<string[]> rowData = new List<string[]> ();

	public static void Save (string fileName)
	{

		// Creating First row of titles manually..//
		string[] rowDataTemp = new string[8];
		rowDataTemp [0] = "月";
		rowDataTemp [1] = "日";
		rowDataTemp [2] = "曜日";
		rowDataTemp [3] = "開始時刻";
		rowDataTemp [4] = "終了時刻";
		rowDataTemp [5] = "休憩時間";
		rowDataTemp [6] = "業務時間";
		rowDataTemp [7] = "作業内容";

		rowData.Add (rowDataTemp);

		// You can add up the values in as many cells as you want.
		for (int i = 0; i < 10; i++) {
			rowDataTemp = new string[8];
			rowDataTemp [0] = "Sushanta" + i; // name
			rowDataTemp [1] = "" + i; // ID
			rowDataTemp [2] = "$" + UnityEngine.Random.Range (5000, 10000); // Income
			rowData.Add (rowDataTemp);
		}

		string[][] output = new string[rowData.Count][];

		for (int i = 0; i < output.Length; i++) {
			output [i] = rowData [i];
		}

		// 获取二次元数列output的第一次元元素的个数
		int length = output.GetLength (0);

		Debug.Log ("length::" + length);

		string delimiter = ",";

		StringBuilder sb = new StringBuilder ();

		for (int index = 0; index < length; index++)
			sb.AppendLine (string.Join (delimiter, output [index]));


		string filePath = getPath (fileName);

		StreamWriter outStream = System.IO.File.CreateText (filePath);
		outStream.WriteLine (sb);
		outStream.Close ();
	}

	/// <summary>
	/// 新建一个CSV文件
	/// </summary>
	/// <param name="fileName">文件名.</param>
	public static void NewCSVFile (string fileName)
	{
		string path = Application.dataPath + "/" + fileName + ".csv";

		Debug.Log (path + " 将要被创建。");

		StreamWriter sw = new StreamWriter (path, false); //true=追記 false=上書き

		sw.Flush ();
		sw.Close ();
	}

	/// <summary>
	/// 编辑CSV文件
	/// </summary>
	/// <param name="txt">要插入的文字</param>
	/// <param name="fileName">文件名</param>
	public static void WriteCSVFile (string text, string fileName)
	{
		string csvFile = Application.dataPath + "/" + fileName + ".csv";

		Debug.Log (csvFile + " 内容将要被修改为。" + text);

		StreamWriter sw = new StreamWriter (csvFile, false); //true=追記 false=上書き

		sw.WriteLine (text);
		sw.Flush ();
		sw.Close ();
	}

	/// <summary>
	/// Gets the path.
	/// </summary>
	/// <returns>The path.</returns>
	/// <param name="fileName">File name.</param>
	private static string getPath (string fileName)
	{
		#if UNITY_EDITOR
		return Application.dataPath + "/CSV/" + fileName + ".csv";
		#elif UNITY_ANDROID
		return Application.persistentDataPath + fileName + ".csv";
		#elif UNITY_IPHONE
		return Application.persistentDataPath+"/" + fileName + ".csv";
		#else
		return Application.dataPath +"/"+fileName + ".csv"
		#endif
	}
}