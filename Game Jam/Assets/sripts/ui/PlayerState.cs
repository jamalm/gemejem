using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour {
    private GameObject itemSelected = null;
    public GameObject trash;

    public float maxObjects;
    public float curObjects;

    public GameObject spaceBar;
    private SpaceBar barScript;

    public Camera camera;

    public GameObject wallBlock;
    public GameObject boostBlock;
    public GameObject iceBlock;
    public GameObject bombBlock;

    private List<GameObject> blocks = new List<GameObject>();

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
        curObjects = blocks.Count;
        if (Input.GetMouseButtonDown(0) && itemSelected != null)
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                GameObject objectl = hit.transform.gameObject;
                GridSlot gridSlot = objectl.GetComponent<GridSlot>();
                placeObject(hit.transform.position, gridSlot);
                Debug.Log(gridSlot.getPosition());
                // Do something with the object that was hit by the raycast.
            }
        }
    }

    public void flipItemSelected(GameObject gameObject)
    {
        itemSelected = gameObject;
        trash.SetActive(itemSelected);
    }

    public void placeObject(Vector3 pos, GridSlot gridSlot)
    {
        barScript.setCurObjects(curObjects);
        if(itemSelected.GetComponent<IceBlock>() != null)
        {
            blocks.Add(Instantiate(itemSelected, new Vector3(pos.x, pos.y -2.3f, pos.z), Quaternion.identity));
        }
        else
        {
            blocks.Add(Instantiate(itemSelected, new Vector3(pos.x, pos.y + 2.5f, pos.z), Quaternion.identity));
        }
        GameObject newBlock = blocks[blocks.Count-1];
        //newBlock.GetComponent<IBlock>().SetData(gridSlot);
        //itemSelected = null;
    }

}
