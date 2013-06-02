using UnityEngine;
using System.Collections;

public class findBall : MonoBehaviour {

	public Transform ball;
	public float speed;

	
	// Update is called once per frame
	void Update () {
		speed = Time.deltaTime * 30;
		
		if (ball.position.z >= transform.position.z + 3){
			transform.Translate(Vector3.forward * speed);
		}

		else if (ball.position.z <= transform.position.z - 3){
			transform.Translate(Vector3.back * speed);
		}

	}
	
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name == "ball"){
			collision.rigidbody.AddForce(10,0,0);
		}

	}	
		


}
