using UnityEngine;
using System.Collections;

//delay effect
 class CombFilter
 {

  private float[] buffer = new float[44100];
  private int position = 0;
  private float g = -.75f;
  private int delayTime = 1000;

  // Input//sound

  public void Input(float[] data, int channels,int delay, float amp)
  {
    g = amp;
    delayTime =delay;
    this.Output(data, channels, amp);
    int writePos = this.position + delayTime;
    writePos = writePos % this.buffer.Length;

    for (int i = 0; i < data.Length; i++)
    {
      this.buffer[writePos] += data[i];
      writePos++;

      if (writePos == buffer.Length)
      {
        writePos = 0;
      }
    }
  }

  //sound of output

  public void Output(float[] data, int channels,float amp)
  {
    g= amp;
    int readPos = this.position;

    for (int i = 0; i < data.Length; i++)
    {
      data[i] += (this.buffer[readPos] * g)/4;
      this.buffer[readPos] = 0f;
      readPos++;

      if (readPos == buffer.Length)
      {
        readPos = 0;
      }
    }

    // this.Input(data, channels);
    this.position = readPos;

  }
 }
