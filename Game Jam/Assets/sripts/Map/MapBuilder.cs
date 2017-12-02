using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBuilder : MonoBehaviour {

    public int sizeX = 0;
    public int sizeZ = 0;
    public float tilesize = 5f;
    public GameObject tile;

    bool isSet = false;
    
    
	// Use this for initialization
	void Start () {
 
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
        //grid.populateGrid(slots);
    }
}
