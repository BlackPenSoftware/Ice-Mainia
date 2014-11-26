using UnityEngine;
using System.Collections;

public class Randoms : MonoBehaviour {

	public bool ShowDebug = false;

	int x_pos = 0;
	int y_pos = 0;

	public GameObject Player;

	public float player_X;

	int x = 0;
	int y = 0;
	int x2 = 100;
	int y2 = 0;

	int timesrange = 20;

	// Update is called once per frame
	void Update () {

		player_X = Player.transform.position.x; 

		if (true) {

			int range = Random.Range (-3, 3) * timesrange;

			y2 += range;
			x2 += 100;

			if (ShowDebug == true) {

				Debug.Log ("X Is: " + x + " X2 Is: " + x2 + " Y is: " + y + " Y2 Is: " + y2 + " And Was Effected By " + range);
			
				Debug.DrawLine (new Vector2 (x, y), new Vector2 (x2, y2), Color.red, 2, true);

			}

			y = y2;
			x = x2;



		} 
	}
}
