using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour {
    private bool itemSelected = false;
    public GameObject trash;

    public float maxObjects;
    public float curObjects;

    public GameObject spaceBar;
    private SpaceBar barScript;

    public Camera camera;

    // Use this for initialization
    void Start()
    {
        trash.SetActive(itemSelected);
        barScript = spaceBar.GetComponentInChildren<SpaceBar>();
        barScript.setMaxObjects(maxObjects);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                GameObject objectl = hit.transform.gameObject;
                Debug.Log(objectl.transform.position);
                // Do something with the object that was hit by the raycast.
            }
        }
    }

    public void flipItemSelected()
    {
        itemSelected = !itemSelected;
        trash.SetActive(itemSelected);
    }

    public void placeObject()
    {
        curObjects += 1;
        barScript.setCurObjects(curObjects);
    }

}
