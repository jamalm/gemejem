using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public abstract class Block : MonoBehaviour, IBlock {

    public string tagOfEffect = "player";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public abstract void Effect(GameObject player);


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
