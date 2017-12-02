using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour {

    public Vector3 position;
    public float maxSpeed = 5;
    public float slowSpeed = 2;
    public float acceleration = 3;
    public Rigidbody runnerRigidBody;
    public GameObject runnerGameObject;
    public Vector3 velocity;

	// Use this for initialization
	void Start () {

        runnerRigidBody = this.GetComponent<Rigidbody>();
        runnerGameObject = this.gameObject;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 forceToAdd = Vector3.zero;

        forceToAdd += getForceToAdd();

        velocity = forceToAdd;

        runnerRigidBody.AddForce(forceToAdd);
	}

    #region Public Methods
    //Pushes a player in a given direction by a given force
    public void pushPlayer(Vector3 direction, float force)
    {

    }

    //Slows down player by specified amount
    public void slowPlayer(float slowBy)
    {

    }

    //change the players speed
    public void changeSpeed(float maxSpeedChange, float accelerationChange)
    {

    }

    #endregion

    #region Private Methods
    private void resetRunnerVlalues()
    {

    }

    private Vector3 getForceToAdd()
    {
        Vector3 force = Vector3.zero;
        force += getKeys() + runnerRigidBody.velocity * Time.deltaTime; 
               
        if(force.magnitude > 0)
        {
            force -= (runnerRigidBody.velocity / slowSpeed * 5) * Time.deltaTime;
        }
        if(force.magnitude > maxSpeed)
        {
            return runnerRigidBody.velocity;
        }

        return force;
    }

    #endregion

    #region temp

    private Vector3 getKeys()
    {
        Vector3 forceToAdd = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            forceToAdd += runnerGameObject.transform.forward * acceleration;
        }
        if (Input.GetKey(KeyCode.S))
        {
            forceToAdd += -runnerGameObject.transform.forward * acceleration;

        }
        if (Input.GetKey(KeyCode.A))
        {
            forceToAdd += -runnerGameObject.transform.right * acceleration;

        }
        if (Input.GetKey(KeyCode.D))
        {
            forceToAdd += runnerGameObject.transform.right* acceleration;
        }

        return forceToAdd;
    }

    #endregion
}
