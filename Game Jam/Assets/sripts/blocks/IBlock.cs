using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBlock {

    void Effect();
    bool TrySetLocation(int x, int y);
}
