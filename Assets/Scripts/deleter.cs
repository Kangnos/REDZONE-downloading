﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleter : MonoBehaviour {

    public float bomblifetime = 3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, bomblifetime);
	}
}
