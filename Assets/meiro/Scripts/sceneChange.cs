using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //For check button
    //public void OnClick()
    //{
    //    Debug.Log("押された!");  // ログを出力
    //}

    //For changing scene
    public void PushStartButton()
    {
        SceneManager.LoadScene("tatsuya");
    }


}
