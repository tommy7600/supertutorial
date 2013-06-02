using UnityEngine;
using System.Collections;

public class keepScore : MonoBehaviour {



	void Start(){
		DontDestroyOnLoad(transform.gameObject);
	}

	void Update(){
		if(playerscore.scorePlayer == 9){
			victory("player");
		}

		else if(enemyScore.scoreEnemy == 9){
			victory("enemy");
		}
	}

	public void victory(string winner){

		if(winner == "player"){
			Debug.Log("Player Wins");
			Application.LoadLevel("PlayerVictory");
		}

		else if(winner == "enemy"){
			Debug.Log("Enemy Wins");
			Application.LoadLevel("EnemyVictory");
		}
	}

	public static void reset(){
		
		Application.LoadLevel("pong");
	}
}
