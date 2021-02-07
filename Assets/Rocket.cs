using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space)){
            //thrusting
            print("thrusting");
            rigidbody.AddRelativeForce(Vector3.up);
        }

        if (Input.GetKey(KeyCode.A)){
            //rotate left
            print("rotate left");
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D)){
            //rotate right
            print("rotate right");
            transform.Rotate(-Vector3.forward);
        }
    }
}
