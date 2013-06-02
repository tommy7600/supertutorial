using UnityEngine;
using System.Collections;

public class dontdestroy : MonoBehaviour {
	public int currentScore;
	
	void DontDestroyLoading(){
		DontDestroyOnLoad(transform.gameObject);
		
	}
}
