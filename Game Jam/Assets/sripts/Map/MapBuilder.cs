using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBuilder : MonoBehaviour {

    public int sizeX = 0;
    public int sizeZ = 0;

    public GameObject gridPrefab;
    public GameObject slotprefab;

    public GridSlot slot;
    public GridMap grid;

    bool isSet = false;
    
    
	// Use this for initialization
	void Start () {
        grid = Instantiate(gridPrefab).GetComponent<GridMap>();
        grid.SetXY(sizeX, sizeZ);
        slot = Instantiate(slotprefab).GetComponent<GridSlot>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!isSet)
        {
            GenerateGrid();
            isSet = true;
        }
	}

    public void GenerateGrid()
    {
        Debug.Log("Generating Grid");
        GridSlot[,] slots = new GridSlot[sizeX, sizeZ];
        for(int i = 0; i < sizeX; i++)
        {
            for(int j = 0; j < sizeZ; j++)
            {
                slots[i,j] = Instantiate(slotprefab, grid.transform);
                Debug.Log("Generating slot: " + slots[i,j]);
            }
        }
        grid.populateGrid(slots);
    }
}
