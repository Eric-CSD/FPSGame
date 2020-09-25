using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverb : MonoBehaviour
{
    CombFilter FBCF1 = new CombFilter();
    CombFilter FBCF2 = new CombFilter();
    CombFilter FBCF3 = new CombFilter();
    CombFilter FBCF4 = new CombFilter();
    AllPassFilter AP1 = new AllPassFilter();
    AllPassFilter AP2 = new AllPassFilter();
    int ReverbSize = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      ReverbSize = 1 + ((int)(GameObject.FindWithTag("RoomCalculator").GetComponent<RoomSizeCalculator>().newRoomSize/1000));
      // ReverbSize = GameObject.FindWithTag("RoomCalculator").GetComponent<RoomSizeCalculator>().newRoomSize;
    }

    void OnAudioFilterRead(float[] data, int channels){
      AP1.Input(data, channels,315 ,0.9999f);
      AP1.Output(data, channels, 0.9999f);
      AP2.Input(data, channels,94 ,0.9999f);
      AP2.Output(data, channels, 0.9999f);
      FBCF1.Input(data, channels, 1734*ReverbSize, -0.99f);
      FBCF2.Input(data, channels, 1951*ReverbSize, -0.99f);
      FBCF3.Input(data, channels, 2502*ReverbSize, -0.99f);
      FBCF4.Input(data, channels, 2830*ReverbSize, -0.99f);
      FBCF1.Output(data, channels, -0.9f);
      FBCF2.Output(data, channels, -0.9f);
      FBCF3.Output(data, channels, -0.9f);
      FBCF4.Output(data, channels, -0.9f);
            // Debug.Log(ReverbSize);
    }

}
