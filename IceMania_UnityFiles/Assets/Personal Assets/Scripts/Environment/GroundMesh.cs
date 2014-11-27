using UnityEngine;
using System.Collections;

public class GroundMesh : MonoBehaviour {

	public float width = 50.0F;
	public float height = 50.0F;

	float x_pos = 0.0F;
	float y_pos = 0.0F;
	float x = 0.0F;
	float y = 0.0F;
	float x_2 = 0.0F;
	float y_2 = 0.0F;

	void Start(){
	
		MeshFilter GroundFilter = GetComponent<MeshFilter> ();
		Mesh Ground = new Mesh ();

		GroundFilter.mesh = Ground;

		// Vertices
		Vector3[] verticies = new Vector3[] {

			new Vector3 (0, 0, 0),	// First Position Or Bottom Right Hand Corner 
			new Vector3 (width, 0, 0),	// Second Position Or Bottom Right Corner 
			new Vector3 (0, height, 0), // Third Position Or Top Left Corner
			new Vector3 (width, height, 0)	// Forth Position Or Top Right Corner

		};

		// Triangles

		int[] tri = new int[6];

		tri [0] = 0;
		tri [1] = 2;
		tri [2] = 1;

		tri [3] = 2;
		tri [4] = 3;
		tri [5] = 1;

		// Normals (Only For Displays)

		Vector3[] normals = new Vector3[4];

		normals [0] = -Vector3.forward;
		normals [1] = -Vector3.forward;
		normals [2] = -Vector3.forward;
		normals [3] = -Vector3.forward;


		// UV (How Textures Are Displayed)

		Vector2[] uv = new Vector2[4];

		uv [0] = new Vector2 (0, 0);
		uv [1] = new Vector2 (1, 0);
		uv [2] = new Vector2 (0, 1);
		uv [3] = new Vector2 (1, 1);

		// Assign Arrays

		Ground.vertices = verticies;
		Ground.triangles = tri;
		Ground.normals = normals;
		Ground.uv = uv;

	}
}
