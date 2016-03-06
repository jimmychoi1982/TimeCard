using UnityEngine;
using System.Collections;

public abstract class Popup : MonoBehaviour {

	protected float StartMoveToX = 100;
	protected float StartMoveToY = 200;

	public abstract void StartToMove ();
	public abstract void OnMoveComplete ();
	public abstract void CloseButton ();
}
