using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class BombBlock : Block {

    public int explosionStrength = 5;
	// Use this for initialization
	void Start () {
        type = GetType().Name;
        SetData(new Vector2(0,0), new Vector2(0,0));
	}

	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Effect(GameObject player) {

    }

}
