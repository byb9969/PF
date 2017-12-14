using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour {
	public GameObject shootClick;
	public int mapPosx, mapPosy;
	public bool cubeKind;
	 void CheckShoot(){
		if (cubeKind) {
			EnemyAttackBtn ();
			Debug.Log ("击中!" + mapPosx + "," + mapPosy + "-->" + cubeKind);
		} else {
			EnemyAttackBtn ();
			Debug.Log ("打空!!" + mapPosx + "," + mapPosy + "-->" + cubeKind);
		}
	}
	void EnemyAttackBtn ()
	{
		for (int i = 0; i < transform.GetComponent<GameInitialize> ().bgWidth; i++) {
			for (int j = 0; j < transform.GetComponent<GameInitialize> ().bgHigh; j++) {
				if (i == mapPosx && j == mapPosy) {
					float posX = 110f * i+50f;
					float posY = 110f * j+50f;
					Debug.Log (posX+">>>" + posY);
					Instantiate (gameObject.GetComponent<GameInitialize> ().attackAnima,new Vector3(posX,posY,0),transform.rotation,transform.Find ("GameViewRoot"));


				}
			}
		}
	}


}
