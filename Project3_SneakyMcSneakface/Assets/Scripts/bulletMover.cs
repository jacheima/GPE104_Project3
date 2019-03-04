using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMover : MonoBehaviour
{

    public float speed = .3f;
    private Rigidbody2D rb;

    public float bulletDestroy = 2.0f;

	// Use this for initialization
	void Start ()
	{
	    rb = GetComponent<Rigidbody2D>();
	    rb.velocity = transform.up * speed;
        Destroy(gameObject, bulletDestroy);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
