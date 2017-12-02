using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSlot : MonoBehaviour {

    public GridMap parentGrid;
    public IBlock block;
    public GameObject physicalSlot;
    public Vector2 gridpos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool hasBlock()
    {
        if (block != null)
        {
            return true;
        }
        else return false;
    }

    public void setBlock(IBlock block)
    {
        this.block = block;
    }

    public IBlock getBlock()
    {
        return block;
    }


    public Vector2 getPosition()
    {
        return gridpos;
    }

    public void setPosition(Vector2 pos)
    {
        gridpos = pos;
    }
}
