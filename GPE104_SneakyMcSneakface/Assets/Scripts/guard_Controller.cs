using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guard_Controller : MonoBehaviour
{

    public Transform player;
    public bool canSeePlayer = false;
    public bool canHearPlayer = false;
    public float maxSpeed = .5f;
    public float speed;
    public int nextWaypoint = 2;
    public Vector3 moveDirection;

    public GameObject position1;
    public GameObject position2;
    public GameObject position3;
    public GameObject position4;

    

    // Use this for initialization
	void Start ()
	{
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (canSeePlayer == false && canHearPlayer == false)
	    {
	        speed = maxSpeed * 0.5f;
            moveToNextWaypoint();
	    }

	    if (canSeePlayer == true)
	    {

	    }

	    if (canHearPlayer == true)
	    {

	    }
	}

    void moveToNextWaypoint()
    {
        if (nextWaypoint == 1)
        {
            moveDirection = position2.transform.position - transform.position;
            transform.position += moveDirection * speed * Time.deltaTime;
            nextWaypoint = 2;
        }
        if (nextWaypoint == 2)
        {
            moveDirection = position3.transform.position - transform.position;
            transform.position += moveDirection * speed * Time.deltaTime;
            nextWaypoint = 3;
        }
        if (nextWaypoint == 3)
        {
            moveDirection = position4.transform.position - transform.position;
            transform.position += moveDirection * speed * Time.deltaTime;
            nextWaypoint = 4;
        }
        if (nextWaypoint == 4)
        {
            moveDirection = position1.transform.position - transform.position;
            transform.position += moveDirection * speed * Time.deltaTime;
            nextWaypoint = 1;
        }

    }

    void Chase()
    {

    }
    void shoot()
    {

    }

    void TurnTowards()
    {

    }
}
