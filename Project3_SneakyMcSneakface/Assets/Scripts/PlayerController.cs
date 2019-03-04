using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerRotationSpeed = 90f;
    public float speed = .3f;
    public float nextFire;
    public float fireRate;

    public GameObject bullet;
    public Transform spawnShot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
	    {
            transform.Rotate(new Vector3(0f, 0f, playerRotationSpeed) * Time.deltaTime);
	    }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
	    {
            transform.Rotate(new Vector3(0f, 0f, -playerRotationSpeed) * Time.deltaTime);
	    }

	    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
	    {
	        transform.position += transform.right * speed;
	    }

	    if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
	    {
	        nextFire = Time.time + fireRate;
	        Instantiate(bullet, spawnShot.position, spawnShot.rotation);
	    }
	}
}
