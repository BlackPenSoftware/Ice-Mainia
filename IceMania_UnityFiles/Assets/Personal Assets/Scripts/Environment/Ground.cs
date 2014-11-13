using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	/* Object Creation */
	public Transform DirtTile_Prefab;

	/* Interger Creation */
	public int Tile_x = 0;
	public int Tile_y = 0;
	public int Tile_width = 32;
	public int Tile_height = 64;
	public int TilesInChunk = 0;

	int ScreenSize_Width = Screen.width;
	int ScreenSize_Height = Screen.height;

	/* Booleans */
	public bool SetTileToBottom = true;
	public bool SetChunkToMax = true;

	/* Floats */
	float TileStartX = 0.0f;
	float TileStartY = 0.0f;
	float TileStartZ = 0.0f;

	void GenGround() {

		int i = 0;
		float offset = 0;
		float offsetamount = Tile_width;

		for (i = 0; i <= TilesInChunk; i++) {

			/* Vectors */
			Vector2 TilePos = new Vector2 (TileStartX + offset, TileStartY);

			Instantiate(DirtTile_Prefab, TilePos, Quaternion.identity);
		
			offset += 2;

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