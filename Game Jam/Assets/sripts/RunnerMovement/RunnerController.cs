using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerController : MonoBehaviour {

    Vector3 fingerPos;
    GameObject runner;

    public RunnerController(GameObject runner)
    {
        fingerPos = Vector3.zero;
        this.runner = runner;
    }

    // Update is called once per frame
    public Vector3 GetSeekPos() {

        fingerPos = Vector3.zero;

        if (Application.platform.Equals(RuntimePlatform.Android)){
            fingerPos = Input.GetTouch(0).position;
        }
        else
        {
            //if (Input.GetMouseButton(0))
            //{
            //    fingerPos = Input.mousePosition;
            //    Debug.Log("Clicking with position: " + fingerPos.x + "," + fingerPos.y + "," + fingerPos.z);
            //    Debug.Log("Player position: " + runner.transform.position.z);

            //    Vector3 position = fingerPos;

            //    position.z = 8;

            //    fingerPos = Camera.main.ScreenToWorldPoint(position);

            //    Debug.Log("Finger position: " + fingerPos.x + "," + fingerPos.y + "," + fingerPos.z);
            //}
            if (Input.GetMouseButton(0))
            {
                RaycastHit hit;

                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
                {
                    fingerPos = hit.point;

                    Debug.Log("finger pos = " + fingerPos.x + ", " + fingerPos.y + ", " + fingerPos.z);
                }
            }
        }
        
        return fingerPos;
	}
}
