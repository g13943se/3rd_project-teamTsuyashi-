using UnityEngine;
using System.Collections;

public class StartButtonTest : MonoBehaviour {

	public string MyRoomSceneName;

	void OnMouseDown(){
		Application.LoadLevel (MyRoomSceneName);
	}
}
