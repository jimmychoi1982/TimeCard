using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class MainSceneTimer : MonoBehaviour {

	[SerializeField] private Image timerImage;

	private bool startTimer = false;

	// Use this for initialization
	void Start () 
	{
	
	}

	// 初期化
	public void Init ()
	{
		// TODO:
		startTimer = true;
	}

	
	// Update is called once per frame
	void Update () 
	{
	
		if (startTimer == true) {

			// TODO:
		}
	}
}
