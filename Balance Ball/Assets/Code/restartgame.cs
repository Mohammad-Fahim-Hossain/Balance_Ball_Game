﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartgame : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (this.gameObject.transform.position.y < -5) 
			Application.LoadLevel (0);
		

		

		
		
	}


			

}
