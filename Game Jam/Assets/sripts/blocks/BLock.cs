using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]

public abstract class Block : MonoBehaviour, IBlock {

    
    public string tagOfEffect = "player";
    public string Type;
    public abstract void Effect(GameObject player);

    public Block(string type) {
        Type = type;
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

}
