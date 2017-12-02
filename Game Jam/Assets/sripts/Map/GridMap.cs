using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap : MonoBehaviour {
    /**
    public int sizeX = 0;
    public int sizeZ = 0;
    public float slotSize;
    public GridSlot[,] slots;
    public GameObject plane;
    public Vector2[,] positions;
    **/

    int sizeX;
    int sizeZ;
    float slotwidth;
    float slotlength;
    public GridSlot[,] slots;
    public GameObject plane;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void populateGrid(GridSlot[,] slots)
    {
        this.slots = slots;
        SetCoords(this.slots);
    }

    public void SetXY(int x, int y)
    {
        sizeX = x;
        sizeZ = y;
        slotwidth = sizeX;
        slotlength = sizeZ;
    }

    public void SetCoords(GridSlot[,] slots)
    {

    }
    
    
}
