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
	public int cloud_height = 32;

	public int CloudsInChunk = 0;

	/* Booleans */
	public bool SetChunkToMax = true;


	void Start(){
	
		if (SetChunkToMax == true) {

			CloudsInChunk = (Screen.width / cloud_width);

		} else {

			CloudsInChunk--;

		}
	
	}

	void OnGUI() {
		if (!CloudTexture) {
			Debug.LogError("Assign a Cloud Texture in the inspector.");
			return;
		}

		int offset = 0;
		int offsetAmount = cloud_width;

		for (int x = 0; x <= CloudsInChunk; x++) { 

			GUI.DrawTexture (new Rect (cloud_x + offset, cloud_y, cloud_width, cloud_height), CloudTexture, ScaleMode.ScaleAndCrop, true, 1.0F);
		
			offset += offsetAmount;

		}
	}
}