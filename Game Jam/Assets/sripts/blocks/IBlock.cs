using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBlock {

    void Effect(GameObject player);
    void SetData(Vector2 start, Vector2 end);
    string SerializeBlock();
}
