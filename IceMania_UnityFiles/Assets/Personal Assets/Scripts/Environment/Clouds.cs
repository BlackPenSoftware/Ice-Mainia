using UnityEngine;
using System.Collections;

public class Clouds : MonoBehaviour {

	/* Objet Creation */
	public GameObject PlayerCamera;

	/* Texture Declaration */
	public Texture CloudTexture;

	/* Cloud Positions */
	public int cloud_x = 0;
	public int cloud_y = 0;
	public int cloud_width = 64;
	public int couud_height = 32;

	void OnGUI() {
		if (!CloudTexture) {
			Debug.LogError("Assign a Cloud Texture in the inspector.");
			return;
		}
		GUI.DrawTexture(new Rect(cloud_x, cloud_y, cloud_width, couud_height), CloudTexture, ScaleMode.ScaleAndCrop, true, 20.0F);
	}
}