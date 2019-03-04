using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCollection : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
            gameManager.instance.currentAmmo += 5.0f;
        }
    }
}
