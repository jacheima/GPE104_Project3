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
            moveToNextPosition();
	    }

	    if (canSeePlayer == true)
	    {

	    }

	    if (canHearPlayer == true)
	    {

	    }
	}

    void moveToNextPosition()
    {
        Debug.Log("Made it to moveToNextPosition");
        if (transform.position == position1.transform.position)
        {
            moveDirection = (position2.transform.position - transform.position);
            transform.position += moveDirection * speed * Time.deltaTime;
        }
        if (transform.position == position2.transform.position)
        {
            moveDirection = (position3.transform.position - transform.position);
            transform.position += moveDirection * speed * Time.deltaTime;
        }
        if (transform.position == position3.transform.position)
        {
            moveDirection = (position4.transform.position - transform.position);
            transform.position += moveDirection * speed * Time.deltaTime;
        }
        if (transform.position == position4.transform.position)
        {
            moveDirection = (position1.transform.position - transform.position);
            transform.position += moveDirection * speed * Time.deltaTime;
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
