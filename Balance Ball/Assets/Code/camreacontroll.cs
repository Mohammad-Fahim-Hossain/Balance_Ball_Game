using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camreacontroll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject ball = GameObject.Find ("Ball");
		Vector3 ballposition = ball.transform.position;

		this.gameObject.transform.position=new Vector3 (ballposition.x, ballposition.y +2f, ballposition.z -3f);
	}
}
