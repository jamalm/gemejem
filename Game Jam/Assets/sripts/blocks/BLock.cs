using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour, IBlock {
    private Vector2 _location;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Effect() {
        
    }

    public bool TrySetLocation(int x, int y)
    {
        _location = new Vector2(x, y);

        return true;
    }

}
