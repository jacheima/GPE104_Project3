using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseController : MonoBehaviour {

    public GameObject guard;
    public Transform player;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_Noise" || other.gameObject.tag == "Player")
        {
            transform.LookAt(player);
        }
    }
}
