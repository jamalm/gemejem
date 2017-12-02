using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {

    public GameObject mapBuilder;
	// Use this for initialization
	void Start () {
        MapBuilder mapScript = mapBuilder.GetComponent<MapBuilder>();
        Vector3 topLeft = mapBuilder.transform.position;
        Vector2 size = new Vector2(mapScript.sizeX * mapScript.tilesize, mapScript.sizeZ * mapScript.tilesize);
        Vector3 Centre = new Vector3(topLeft.x + (size.x/2), mapBuilder.transform.position.y, topLeft.z + (size.y/2));
        this.transform.position = new Vector3(Centre.x, Centre.y+50, Centre.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
