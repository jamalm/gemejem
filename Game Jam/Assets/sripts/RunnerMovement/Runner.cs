using System;
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
    public float slowingRad;
    private RunnerController controller;

	// Use this for initialization
	void Start () {
        
        this.runnerRigidBody = this.GetComponent<Rigidbody>();
        this.runnerGameObject = this.gameObject;
        this.controller = new RunnerController(this.gameObject);
        Debug.Log("GameObject: " + this.gameObject.name);
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 forceToAdd = Vector3.zero;
        forceToAdd += getForceToAdd();
        //get rid of y movement
        forceToAdd = new Vector3(forceToAdd.x, 0, forceToAdd.z);
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

    //resets the runners variables back to their original values
    private void resetRunnerVlalues()
    {

    }

    //gets the force to add to the runner
    private Vector3 getForceToAdd()
    {
        Vector3 force = Vector3.zero;
        force += getKeys() + this.runnerRigidBody.velocity * Time.deltaTime;

        if (controller.GetSeekPos() != Vector3.zero)
        {
            force += Arrive(controller.GetSeekPos()) + this.runnerRigidBody.velocity * Time.deltaTime;
        }

        
               
        if(force.magnitude > 0)
        {
            force -= (this.runnerRigidBody.velocity / this.slowSpeed * 5) * Time.deltaTime;
        }
        if(force.magnitude > maxSpeed)
        {
            return runnerRigidBody.velocity;
        }

        return force;
    }

    //Gets force required to arrive at a point
    private Vector3 Arrive(Vector3 point)
    {
        float distance = Vector3.Distance(runnerGameObject.transform.position, point);
        Vector3 force = SeekPoint(point);
        if(distance < slowingRad)
        {
            force = force.normalized * maxSpeed * (distance / slowingRad);
        }
        else
        {
            force = force.normalized * maxSpeed;
        }
        return force;
    }

    //Gets force required to seek a point
    private Vector3 SeekPoint(Vector3 point)
    {
        Vector3 desired = point - runnerGameObject.transform.position;
        desired.Normalize();
        desired *= maxSpeed;
        return desired - runnerRigidBody.velocity;
    }

    #endregion

    #region temp

    private Vector3 getKeys()
    {
        Vector3 forceToAdd = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            forceToAdd += this.runnerGameObject.transform.forward * this.acceleration;
        }
        if (Input.GetKey(KeyCode.S))
        {
            forceToAdd += -this.runnerGameObject.transform.forward * this.acceleration;
        }
        if (Input.GetKey(KeyCode.A))
        {
            forceToAdd += -this.runnerGameObject.transform.right * this.acceleration;
        }
        if (Input.GetKey(KeyCode.D))
        {
            forceToAdd += this.runnerGameObject.transform.right* this.acceleration;
        }

        return forceToAdd;
    }

    #endregion
}
