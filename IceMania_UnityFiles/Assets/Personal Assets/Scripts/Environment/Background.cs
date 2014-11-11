using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	/* Object Declaration*/
	public GameObject PlayerCamera;

	/* Color Creation */
	public Color background = Color.black;

	void Start(){

		/* Sets The Background Color For The Whole View Of The Camera */
		PlayerCamera.camera.backgroundColor = background;

	}
		
	void Update() {}

}