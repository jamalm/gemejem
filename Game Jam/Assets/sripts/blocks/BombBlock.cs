using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class BombBlock : Block {

    public int explosionStrength = 5;
	// Use this for initialization
	void Start () {
        blockType = GetType().Name;
<<<<<<< HEAD
        SetData(new Vector2(0,0), new Vector2(0,0));
=======
        SetData(new Vector2(0,1), Orientation.Up);
        Debug.Log(Orientation.Up);
        Debug.Log(data);
>>>>>>> cfbd09008818fd8d6cc7d2976aded9394a23d243
	}

	
	// Update is called once per frame
	void Update () {

		
	}

    public override void Effect(GameObject player) {

    }

}
