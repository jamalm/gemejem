using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class BlockData : MonoBehaviour {

    public Vector2 start;
    public Vector2 end;
    public string type;

    public BlockData(Vector2 _start, Vector2 _end, string _type) {
        start = _start;
        end = _end;
        type = _type;
    }
}
