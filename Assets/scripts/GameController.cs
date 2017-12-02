using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public int enemyAttack_x, enemyAttack_y;
	public bool enemyAttack;
	// Use this for initialization
	void Start ()
	{
		
	}

	public void EnemyAttackBtn ()
	{
		for (int i = 0; i < transform.GetComponent<GameInitialize> ().bgWidth; i++) {
			for (int j = 0; j < transform.GetComponent<GameInitialize> ().bgHigh; j++) {
				if (i == enemyAttack_x && j == enemyAttack_y) {
					float posX = 110f * i+50f;
					float posY = 110f * j+50f;
					Debug.Log (posX+">>>" + posY);
					Instantiate (gameObject.GetComponent<GameInitialize> ().attackAnima,new Vector3(posX,posY,0),transform.rotation,transform.Find ("GameViewRoot"));


				}
			}
		}
	}
	// Update is called once per frame
	void Update ()
	{
	}
}
