using UnityEngine;
using System.Collections;

public class MenuButtonTest : MonoBehaviour {

	public string sceneName;

	void Start () {
	
	}

	void Update () {
	
	}

	void OnMouseDown(){
		Application.LoadLevel (sceneName);
	}
}
