using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
[Serializable]
public abstract class Block : MonoBehaviour, IBlock {

    
    public string tagOfEffect = "player";
    public BlockData data;
    public string blockType;
    public abstract void Effect(GameObject player);

    public void SetData(Vector2 start, Orientation orientation) {
        data = new BlockData(start, orientation, blockType);
        Debug.Log("Setting info -- ");
        Debug.Log(JsonUtility.ToJson(data));
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
