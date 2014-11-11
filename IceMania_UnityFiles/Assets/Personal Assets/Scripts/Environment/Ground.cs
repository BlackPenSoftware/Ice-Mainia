using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	/* Object Creation */
	public Transform DirtTile_Prefab;

	/* Interger Creation */
	public int Tile_x = 0;
	public int Tile_y = 0;
	public int Tile_width = 64;
	public int Tile_height = 64;

	public int TilesInChunk = 0;

	/* Booleans */
	public bool SetTileToBottom = true;
	public bool SetChunkToMax = true;


	void GenGround() {

		int i = 0;
		int offset = 0;
		int offsetamount = Tile_width;

		for (i = 0; i <= TilesInChunk; i++) {

			Instantiate(DirtTile_Prefab, new Vector3(0, 0, 0), Quaternion.identity); // Not Working Needs to Draw The Ground For The Truck Useing Prefabs Because Of Box Collider 
			offset = offset + offsetamount;

		}
	}

	void Start(){
	
		if (SetTileToBottom == true) {

			Tile_y = (Screen.height - Tile_height);

		}

		if (SetChunkToMax == true) {
		
			TilesInChunk = (Screen.width / Tile_width);
		
		} else {
		
			TilesInChunk--;
		
		}

	
		GenGround ();

	}
}