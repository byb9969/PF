using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitialize : MonoBehaviour {
	public GameObject gameBg,planeBody;
	public int[,] gameMap;
	public int[,] 
	plane_1 = new int[4,5]{{0,0,1,0,0},{1,1,1,1,1},{0,0,1,0,0},{0,1,1,1,0}};
//	public int[,] intArray = new int[2,3] {{1,2,3},{4,5,6}};

	private int bgWidth = 9,bgHigh = 16;
	// Use this for initialization
	void Start () {
		initializeBg ();
		initializePlane ();
	}
	void initializeBg(){
//		GameObject go = gameObject.GetComponent<GameController>().gameBg;
		gameMap = new int[bgWidth,bgHigh];
		for (int x = 0; x < bgWidth; x++) {
			for (int y = 0; y < bgHigh; y++) {
				gameMap [x, y] = 0;

			}
		}
		for(int i=0;i<bgWidth;i++){
			for(int j=0;j<bgHigh;j++){
				if (gameMap [i, j] == 0) {
					GameObject bgCube = Instantiate (gameObject.GetComponent<GameInitialize> ().gameBg, transform.Find ("GameViewRoot"));
					bgCube.name = "bgCube" + i + "," + j;
					float posX = 110f * i;
					float posY = 110f * j;
					bgCube.transform.position = new Vector3 (posX + 50f, posY + 50f, 0);
				}
			
			}
		}

	}
	void initializePlane(){
		for (int x = 0; x < plane_1.GetLength(0); x++) {
			for (int y = 0; y < plane_1.GetLength(1); y++) {
				gameMap [x, y] = plane_1[x,y];
				Debug.Log (plane_1[x,y]);
			}
		}
		for(int i=0;i<bgWidth;i++){
			for(int j=0;j<bgHigh;j++){
				if (gameMap [i, j] == 1) {
//					GameObject.Destroy (gameObject);
					GameObject bgCube = Instantiate (gameObject.GetComponent<GameInitialize> ().planeBody, transform.Find ("GameViewRoot"));
					bgCube.name = "plane" + i + "," + j;
					float posX = 110f * i;
					float posY = 110f * j;
					bgCube.transform.position = new Vector3 (posX + 50f, posY + 50f, 0);
					Debug.Log (gameMap[i,j]);
				}

			}
		}
	}
}
