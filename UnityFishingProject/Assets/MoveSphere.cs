﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour {

	//Start is called once 
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		//s = ut + 1/2 at² - equation for distance

		//rotate our object
		transform.Rotate(0, 0, 0);
		//move our object
        //With all axis
		//transform.Translate((int)PiData.accelerationOfX,(int)PiData.accelerationOfY, (int)PiData.accelerationOfZ);

        //without Y axis
        transform.Translate((int)PiData.accelerationOfX, 0, (int)PiData.accelerationOfZ);

    }
}