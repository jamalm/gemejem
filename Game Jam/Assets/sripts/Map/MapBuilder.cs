using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBuilder : MonoBehaviour {

    public int sizeX = 0;
    public int sizeZ = 0;
    public float tilesize = 5f;
    public GameObject tile;
    public GameObject grid;
    GridMap gridmap;
    bool isSet = false;
    
    
	// Use this for initialization
	void Start () {
        gridmap = grid.GetComponent<GridMap>();
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
        GameObject[,] slots = new GameObject[sizeX, sizeZ];
        for(int i = 0; i < sizeX; i++)
        {
            for(int j = 0; j < sizeZ; j++)
            {
                slots[i,j] = Instantiate(tile,new Vector3(tilesize*i, 0.2f, tilesize*j),Quaternion.identity);
                Debug.Log("Generating slot: " + slots[i,j]);
            }
        }
        gridmap.populateGrid(slots);
    }
}
