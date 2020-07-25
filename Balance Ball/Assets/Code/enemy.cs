using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	public GameObject enemyobj;

	public int count;



	// Use this for initialization
	void Start () {
		for (int i = 0; i < this.count; i++) {
			GameObject newenemy = (GameObject)GameObject.Instantiate (enemyobj);
			newenemy.transform.position = new Vector3 (0, 0.8f, 9);
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
