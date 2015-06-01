using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public int buttonNumber;
	AudioSource audio;

	void Start (){
		audio = gameObject.GetComponent<AudioSource> ();
		/*Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
		Debug.Log ("x:y "+max.x+":"+max.y);
		Vector2 scale = max/4;
		transform.localScale = scale;
		var sr = gameObject.GetComponent<SpriteRenderer> ();
		float x = sr.bounds.size.x;
		float y = sr.bounds.size.y;*/
		int scWidth = Screen.width;
		int scHeight = Screen.height;
		int spWidth = (int)gameObject.GetComponent<SpriteRenderer> ().bounds.size.x;
		int spHeight = (int)gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;

		int width = (spWidth * buttonNumber) - (scWidth / 2);
		int height = (buttonNumber > 4 ? spHeight : 0) - (scHeight / 2);
		//Vector2 pos = new Vector2 (width,height);
		//transform.position = pos;
	}

	void Update () {
	
	}

	void OnMouseDown(){
		audio.Play ();
	}
}
