using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBlock : Block {

    public int explosionStrength = 5;
	// Use this for initialization
	void Start () {
	}

    public BombBlock() :base("BombBlock") {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Effect(GameObject player) {

    }

}
