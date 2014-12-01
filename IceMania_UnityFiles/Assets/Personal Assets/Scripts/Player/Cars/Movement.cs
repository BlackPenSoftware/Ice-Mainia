using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Texture2D gas = null;
	public Texture2D stop = null;
	public Texture2D forward = null;
	public Texture2D back = null;

	public Transform Player = null;

	void Start (){
		if(!Player){

			Debug.Log ("No Object Set As Player Prefab!");

		}
	}

	// Update is called once per frame
	void OnGUI () {
	
		while(GUI.Button(new Rect (20, 20, 100, 100), "Gas")){

			Debug.Log ("Button Pressed");

			Player.transform.Translate (Vector3.right * Time.deltaTime * 100);

		}

		while(GUI.Button(new Rect (20, 150, 100, 100), "Stop")){

			Debug.Log ("Button Pressed");

			Player.transform.Translate (Vector3.left * Time.deltaTime * 100);

		}

	}
}
