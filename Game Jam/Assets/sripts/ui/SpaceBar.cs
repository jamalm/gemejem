using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpaceBar : MonoBehaviour { 

    private float maxSpace;
    private float curSpace;

    private Image image;
	// Use this for initialization
	void Start () {
        image = GetComponentInParent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        image.fillAmount = 1 - curSpace / maxSpace;
	}

    public void setCurObjects(float _curObjects)
    {
        curSpace = maxSpace - _curObjects;
    }

    public void setMaxObjects(float _maxObjects)
    {
        maxSpace = _maxObjects;
        curSpace = _maxObjects;
    }
}
