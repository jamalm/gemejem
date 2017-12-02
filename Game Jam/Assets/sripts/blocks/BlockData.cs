using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class BlockData : MonoBehaviour {

    public float x;
    public float y;
    public Orientation orientation;
    public string type;

    public BlockData(Vector2 _start, Orientation _orientation, string _type) {
        x = _start.x;
        y = _start.y;
        _orientation = orientation;
        type = _type;
    }
}
