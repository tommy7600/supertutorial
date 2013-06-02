using UnityEngine;
using System.Collections;

public class playerscore : MonoBehaviour {

	public static int scorePlayer = 0;

	void OnCollisionEnter(Collision collision){
		
		enemyScore.scoreEnemy = enemyScore.scoreEnemy + 1;
		keepScore.reset();
		
	}

}
