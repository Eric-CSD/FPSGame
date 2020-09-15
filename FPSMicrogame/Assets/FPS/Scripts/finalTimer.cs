using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalTimer : MonoBehaviour
{
  private float timer;
  private bool completion = false;
  private float  seconds;
  private float  minutes;
  private float  millis;
  [SerializeField] Text finalTimerText;
    // Start is called before the first frame update
    void Start()
    {
      timer = Time.time;
          seconds = (int)(timer % 60);
          minutes = (int)(timer /60);
          millis = (int)((timer*1000)%100);

          finalTimerText.text= minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + millis.ToString("00");
    }

    // Update is called once per frame
//     void Update()
//     {
//       timer = GetComponent<StopWatch>().timer;
//           seconds = (int)(timer % 60);
//           minutes = (int)(timer /60);
//           millis = (int)((timer*1000)%100);
//
//           finalTimer.text= minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + millis.ToString("00");
//         }
//     }
}
