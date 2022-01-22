using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    [SerializeField] private float moveSpeed = 5.0f;

     void Update()
     {
        velocity = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            velocity.z += 1;
        }
        if(Input.GetKey(KeyCode.A))
        {
            velocity.x -= 1;
        }
        if(Input.GetKey(KeyCode.S))
        {
            velocity.z -= 1;
        }
        if(Input.GetKey(KeyCode.D))
        {
            velocity.x += 1;
        }

        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        if(velocity.magnitude > 0)
        {
            transform.position += velocity;
        }
    }
}

