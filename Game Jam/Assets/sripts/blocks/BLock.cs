using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
[Serializable]
public abstract class Block : MonoBehaviour, IBlock {

    
    public string tagOfEffect = "player";
    public BlockData data;
    public string type;
    public abstract void Effect(GameObject player);

    public void SetData(Vector2 start, Vector2 end) {
        data = new BlockData(start, end, type);
    }
    private void OnCollisionEnter(Collision collision)
    {
        var otherObj = collision.gameObject;

        if (otherObj.tag == tagOfEffect)
        {
            GetComponent<AudioSource>().Play();
            Effect(otherObj);
        }
    }
    public string SerializeBlock() {
        return JsonUtility.ToJson(data);
    }

}
