using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultexp : MonoBehaviour
{
    public Text ScoreText;
    int minutes;
    float seconds;
    // Start is called before the first frame update
    void Start()
    {
        minutes = Timer.getscore1();
        seconds = Timer.getscore2();
        ScoreText.text = string.Format("TIME {0}分{1}秒", minutes, (int)seconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
