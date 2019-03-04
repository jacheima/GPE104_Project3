using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class nextWaypoint : MonoBehaviour  
{
    public GameObject guard;
    public float currentWaypoint = 1;
    public float nextWP = 2;

    private gameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(guard.tag.Equals("guard"))
        {
            gameManager.instance.didReachWP = true;   
        }
    }
}
