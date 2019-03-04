using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float playerRotateSpeed = 90.0f;
    public float playerSpeed = 0.1f;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0.0f, 0.0f, playerRotateSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0.0f, 0.0f, -playerRotateSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.right * playerSpeed;
        }
    }
}
