using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class BombBlock : Block {

    public int explosionStrength = 5;
	// Use this for initialization
	void Start () {
        blockType = GetType().Name;
        SetData(new Vector2(0,1), Orientation.Up);
        Debug.Log(Orientation.Up);
        Debug.Log(data);
	}

	
	// Update is called once per frame
	void Update () {

        SetData(new Vector2(0, 1), Orientation.Up);
		
	}

    public override void Effect(GameObject player) {

    }

}
