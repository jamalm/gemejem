using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBlock : Block {


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
