﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBlock {

    void Effect(GameObject player);

    string SerializeBlock();
}
