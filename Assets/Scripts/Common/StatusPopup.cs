using UnityEngine;
using System.Collections;

public class StatusPopup : Popup {

	public void Init ()
	{
		Debug.Log ("Status Popup" + StartMoveToX);
		Debug.Log ("Status Popup" + StartMoveToY);
	}

	public override void StartToMove ()
	{

	}

	public override void OnMoveComplete ()
	{

	}

	public override void CloseButton ()
	{
		Debug.Log ("CloseButton OnClick");
	}
}
