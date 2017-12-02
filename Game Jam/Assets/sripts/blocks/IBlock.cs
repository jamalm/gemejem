using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBlock {

    void Effect(GameObject player);
    void SetData(Vector2 start, Orientation orientaiton);
    string SerializeBlock();
}
