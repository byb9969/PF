using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour {
	public GameObject shootClick;
	public void CheckShoot(){
		if(shootClick.transform.tag == "Plane"){
			Debug.Log ("shoot the plane!!!");
			
		}else if(shootClick.transform.tag == "BgMap"){
			Debug.Log ("you shoot air...");
		}
	}
}
