using UnityEngine;
using System.Collections;

public class BackButtonTest : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
	
	}

	void OnMouseDown(){
		Application.LoadLevel ("MyPageScene");
	}
}
