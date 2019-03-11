using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class GuardController : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed = .01f;
    private Transform currentPatrolPoint;
    private int currentPatrolIndex;


	// Use this for initialization
	void Start ()
	{
	    currentPatrolIndex = 0;
	    currentPatrolPoint = patrolPoints[currentPatrolIndex];
	}
	
	// Update is called once per frame
	void Update ()
	{
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        //Check to see if the guard has reached the Way Point
	    if (Vector3.Distance(transform.position, currentPatrolPoint.position) < 1f)
	    {
            //The guard has reached the patrol point - get the next patrol point
            //Check to see if there are any more patrol points - if not go back to the first one
	        if (currentPatrolIndex + 1 < patrolPoints.Length)
	        {
	            currentPatrolIndex++;
	        }
	        else
	        {
	            currentPatrolIndex = 0;
	        }

	        currentPatrolPoint = patrolPoints[currentPatrolIndex];
	    }

	    //Turn to face the next patrol point
	    //Finding the direction Vector that points to the next patrol point
	    Vector3 patrolPointDir = currentPatrolPoint.position - transform.position;
	    //Figure out the rotation in degrees that we need to turn towards
	    float angle = Mathf.Atan2(patrolPointDir.y, patrolPointDir.x) * Mathf.Rad2Deg;
	    //Made the rotation that we need to face
	    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
	    //Apply the rotation to our transform
	    transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180f);


        //the hearing mechanic
        


    }
}
