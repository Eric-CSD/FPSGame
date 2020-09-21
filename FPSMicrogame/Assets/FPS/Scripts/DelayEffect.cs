using UnityEngine;
 using System.Collections;

//delay effect
 class DelayEffect
 {

  private float[] buffer = new float[44100];

  private int position = 0;

  private float g = .75f;

  private int delayTime = 18000;


  // Input//sound

  public void Input(float[] data, int channels)

  {

    int dst = this.position + delayTime;

    dst = dst % this.buffer.Length;

    for (int i = 0; i < data.Length; i++)

    {

      this.buffer[dst] += data[i];


      dst++;

      if (dst == buffer.Length) { dst = 0; }

    }

  }


  //sound of output

  public void Output(float[] data, int channels)

  {

    int src = this.position;

    for (int i = 0; i < data.Length; i++)

    {

      data[i] += this.buffer[src] * g;

      this.buffer[src] = 0f;


      src++;

      if (src == buffer.Length) { src = 0; }

    }

    this.Input(data, channels);


    this.position = src;

  }
 }
