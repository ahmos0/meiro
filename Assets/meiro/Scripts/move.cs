using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody rb;
    public float velocity = 20.0f;
    public float v;
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().velocity = Vector3.right;
        }
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity = Vector3.left;
        }
        if(Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = Vector3.forward;
        }
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity = (-1)*Vector3.forward;
        }
    }
}


