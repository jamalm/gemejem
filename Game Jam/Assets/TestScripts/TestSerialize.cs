﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSerialize : MonoBehaviour {

    public Block block;
	// Use this for initialization
	void Start () {
        Debug.Log(block.SerializeBlock());

        var reqHandler = new RequestHandler();
        reqHandler.MakePlayerId("kennyk");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
