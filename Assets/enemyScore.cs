using UnityEngine;
using System.Collections;

public class enemyScore : MonoBehaviour {

	public static int scoreEnemy = 0;

	void OnCollisionEnter(Collision collision ){
	
		playerscore.scorePlayer = playerscore.scorePlayer + 1;
		keepScore.reset();
		
	}

}
