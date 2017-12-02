using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class BombBlock : Block {

    public int explosionStrength = 5;
	// Use this for initialization
	void Start () {
        blockType = GetType().Name;



	}

	
	// Update is called once per frame
	void Update () {

		
	}

    public override void Effect(GameObject player) {

    }

}
