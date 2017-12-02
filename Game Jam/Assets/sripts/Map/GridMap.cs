﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap : MonoBehaviour {

    int sizeX;
    int sizeZ;
    public GridSlot[,] slots;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void populateGrid(GameObject[,] slots)
    {
        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeZ; j++)
            {
                this.slots[i, j] = slots[i, j].GetComponent<GridSlot>();
            }
        }
    }

    public void SetXY(int x, int y)
    {
        sizeX = x;
        sizeZ = y;
    }

    public void getGrid()
    {

    }

    public GameObject getSlot(Vector2 index)
    {
        return slots[(int)index.x, (int)index.y].gameObject;
    }
}
