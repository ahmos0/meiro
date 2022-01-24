using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Timer : MonoBehaviour 
{
	/*[SerializeField]*/public static int minute;
	/*[SerializeField]*/public static float seconds;
	//　前のUpdateの時の秒数
	private float oldSeconds;
	//　タイマー表示用テキスト
	private Text timerText;

    public static int getscore1()
    {
        return minute;
    }

    public static float getscore2()
    {
        
        return seconds;
    }
 
	void Start() 
    {
		minute = 0;
		seconds = 0f;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<Text> ();
	}
 
	void Update() 
    {
		seconds += Time.deltaTime;
		if(seconds >= 60f) {
			minute++;
			seconds = seconds - 60;
		}
        /*if(seconds >= 2)
        {
            SceneManager.LoadScene("exp");
        }*/
		//　値が変わった時だけテキストUIを更新
		if((int)seconds != (int)oldSeconds)
        {
			timerText.text = "TIME " + minute.ToString("00") + ":" + ((int) seconds).ToString ("00");
		}
		oldSeconds = seconds;
	}
}