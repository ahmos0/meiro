using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Move : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0f, 1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, 0f, -1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1f, 0f, 0f);
        }
 
    }
 
}