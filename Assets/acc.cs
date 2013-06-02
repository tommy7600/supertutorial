using UnityEngine;
using System.Collections;

public class acc : MonoBehaviour {
	public int speed = 10;
	
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name == "ball"){
			collision.rigidbody.AddForce(speed,0,0);
		}

	}
}


