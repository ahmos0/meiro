using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muki_Player : MonoBehaviour {

    public float speed; //プレイヤーの動くスピード
    
    private float x; //x方向のImputの値
    private float z; //z方向のInputの値
    private Rigidbody rigd;

    void Start()
    {
        rigd = GetComponent<Rigidbody>(); //プレイヤーのRigidbodyを取得
    }

    void Update()
    {

        x = Input.GetAxis("Horizontal"); //x方向のInputの値を取得
        z = Input.GetAxis("Vertical"); //z方向のInputの値を取得

        var movedir = new Vector3(x, 0, z);
        
        rigd.velocity = new Vector3(x * speed, 0, z * speed); //プレイヤーのRigidbodyに対してInputにspeedを掛けた値で更新し移動

        if (movedir.magnitude > 0.1f)
        {
            transform.rotation = Quaternion.LookRotation(movedir);  //ベクトルの情報をQuaternion.LookRotationに引き渡し回転量を取得しプレイヤーを回転させる   
        }
    }
}