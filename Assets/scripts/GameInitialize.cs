using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitialize : MonoBehaviour {
	public GameObject gameBg,planeBody;

	private int bgWidth = 9,bgHigh = 16;
	// Use this for initialization
	void Start () {
		initialize ();
	}
	void initialize(){
//		GameObject go = gameObject.GetComponent<GameController>().gameBg;
		for(int i=0;i<=bgWidth;i++){
			for(int j=0;j<=bgHigh;j++){
			GameObject bgCube = Instantiate (gameObject.GetComponent<GameInitialize>().gameBg,transform.Find("GameViewRoot"));
			bgCube.name = "cube"+i+","+j;
			float posX = 110f * i;
			float posY = 110f * j;
			bgCube.transform.position = new Vector3 (posX+50f,posY+50f,0);
			
			}
		}

	}
}
