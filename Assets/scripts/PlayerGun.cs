using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour {
	public GameObject shootClick;
	public int mapPosx, mapPosy;
	public bool cubeKind;
	 void CheckShoot(){
		if (cubeKind) {
			
			Debug.Log ("击中!" + mapPosx + "," + mapPosy + "-->" + cubeKind);
		} else {
			Debug.Log ("打空!!" + mapPosx + "," + mapPosy + "-->" + cubeKind);
		}
	}
}
