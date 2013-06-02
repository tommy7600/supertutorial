using UnityEngine;
using System.Collections;

public class scoreGui : MonoBehaviour {
	void Start(){
		DontDestroyOnLoad(transform.gameObject);
	}
	// Update is called once per frame
	void OnGUI() {
		GUI.Label(new Rect(10, 10, 100, 20), playerscore.scorePlayer + " vs " + enemyScore.scoreEnemy);
	}
}
