using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverb : MonoBehaviour
{
    CombFilterLeft FBCFL1 = new CombFilterLeft();
    CombFilterLeft FBCFL2 = new CombFilterLeft();
    CombFilterLeft FBCFL3 = new CombFilterLeft();
    CombFilterLeft FBCFL4 = new CombFilterLeft();
    CombFilterLeft FBCFL5 = new CombFilterLeft();
    CombFilterLeft FBCFL6 = new CombFilterLeft();
    CombFilterLeft FBCFL7 = new CombFilterLeft();
    CombFilterLeft FBCFL8 = new CombFilterLeft();
    // CombFilterRight FBCFR1= new CombFilterRight();
    // CombFilter FBCF2 = new CombFilter();
    // CombFilter FBCF3 = new CombFilter();
    // CombFilter FBCF4 = new CombFilter();
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
      AP1.Input(data, channels,2000 ,0.7f);
      AP1.Output(data, channels,121*ReverbSize ,1f);
      AP2.Input(data, channels,2000,0.7f);
      AP2.Output(data, channels,67*ReverbSize,1f);
      FBCFL1.Input(data, channels, 1343*ReverbSize, 1f);
      FBCFL2.Input(data, channels, 1491*ReverbSize, 1f);
      FBCFL3.Input(data, channels, 1520*ReverbSize, 1f);
      FBCFL4.Input(data, channels, 1657*ReverbSize, 1f);
      FBCFL5.Input(data, channels, 1743*ReverbSize, 1f);
      FBCFL6.Input(data, channels, 1891*ReverbSize, 1f);
      FBCFL7.Input(data, channels, 1920*ReverbSize, 1f);
      FBCFL8.Input(data, channels, 2057*ReverbSize, 1f);

      // FBCFR1.Input(data, channels, 2324, 0.9f);
      // FBCF2.Input(data, channels, 1951*ReverbSize, -0.99f);
      // FBCF3.Input(data, channels, 2502*ReverbSize, -0.99f);
      // FBCF4.Input(data, channels, 2830*ReverbSize, -0.99f);
      // FBCF2.Output(data, channels, 0.9f);
      FBCFL1.Output(data, channels,1343*ReverbSize, 0.81f);
      FBCFL2.Output(data, channels,1491*ReverbSize, 0.79f);
      FBCFL3.Output(data, channels,1520*ReverbSize, 0.51f);
      FBCFL4.Output(data, channels,1657*ReverbSize, 0.75f);
      FBCFL5.Output(data, channels,1743*ReverbSize, 0.83f);
      FBCFL6.Output(data, channels,1891*ReverbSize, 0.84f);
      FBCFL7.Output(data, channels,1920*ReverbSize, 0.84f);
      FBCFL8.Output(data, channels,2057*ReverbSize, 0.71f);
      // FBCFR1.Output(data, channels,2258, 0.5f);
      // FBCF3.Output(data, channels, -0.9f);
      // FBCF4.Output(data, channels, -0.9f);
            // Debug.Log(ReverbSize);
      for(int i= 0; i<data.Length; i++){
        if (i%2==0){
        data[i]*=-1f;
        }
      }
    }

}
