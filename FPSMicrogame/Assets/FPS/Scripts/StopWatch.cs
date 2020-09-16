using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{

    public float timer;
    float seconds;
    float minutes;
    float millis;

    [SerializeField] Text stopWatchText;

    // Start is called before the first frame update

    void Awake(){
      DontDestroyOnLoad(transform.gameObject);
      timer = 0;
    }

    // void Start()
    // {
    //
    // }

    // Update is called once per frame
    void Update()
    {
        StopWatchCalc();
    }

    void StopWatchCalc(){
      timer += Time.deltaTime;
      seconds = (int)(timer % 60);
      minutes = (int)(timer /60);
      millis = (int)((timer*1000)%100);

      stopWatchText.text= minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + millis.ToString("00");
    }
    void OnDisable()
      {
    PlayerPrefs.SetFloat("timer", timer);
      }
}
