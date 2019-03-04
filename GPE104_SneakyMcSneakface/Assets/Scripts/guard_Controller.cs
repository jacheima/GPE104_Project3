using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guard_Controller : MonoBehaviour
{

    
    public bool canSeePlayer = false;
    public bool canHearPlayer = false;

    public Transform player;
    public GameObject guard;
    public float nextWaypoint = 2;

    public float guardSpeed = .5f;
    public float maxGuardSpeed = 1.0f;

    public float moveDirection;

    public GameObject position1;
    public GameObject position2;
    public GameObject position3;
    public GameObject position4;

    public bool didReachWP = false;

    

    // Use this for initialization
	void Start ()
	{
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (canSeePlayer == false && canHearPlayer == false)
	    {
	        
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
        if(nextWaypoint == 2)
        {
            transform.position += new Vector3(guardSpeed, 0, 0) * Time.deltaTime;
            if (didReachWP == true)
            {

            }
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
