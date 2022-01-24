using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeResult : MonoBehaviour
{
    //private Rigidbody _rigidbody;  //Check only
    private Transform _mytrans;
    private Vector3 _pos;

    // Start is called before the first frame update
    void Start()
    {
        // Input each vector goal
        /*_pos.x = -10;
        _pos.y = 0;
        _pos.z = 10;*/
    }

    // Update is called once per frame
    void Update()
    {
        
        _mytrans = this.transform;

        /*if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0.0f, 0.0f, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0.0f, 0.0f, -0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-0.1f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(0.1f, 0.0f, 0.0f);
        }*/

        //&& _mytrans.position.x <= -2206

        //Please change below as you like 
        if (_mytrans.position.z >= 1941)
        {
            SceneManager.LoadScene("niwakaResult");
        }   
    }

}
