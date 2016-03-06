using UnityEngine;
using System.Collections;

public class CommonInformationPopup : Popup {

	[SerializeField] private StatusPopup statusPopup;

	void Start ()
	{
		StartMoveToX = 300;
		StartMoveToY = 400;

		Debug.Log (StartMoveToX);
		Debug.Log (StartMoveToY);

		Debug.Log (base.StartMoveToX);
		Debug.Log (base.StartMoveToY);

		statusPopup.Init ();
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


