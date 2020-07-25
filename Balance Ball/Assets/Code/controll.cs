using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class controll : MonoBehaviour {

	public float force = 1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		if (vertical > 0) {
			this.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.forward * force);
		}
		if (vertical < 0) {
			this.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.back * force);
		}
		if (horizontal > 0) {
		
			this.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.right * force);
	    }
		if(horizontal<0){
			this.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.left * force);
		}
	}
	public void OnCollisionEnter(){
		this.GetComponent<AudioSource>().Play ();	

	}

}