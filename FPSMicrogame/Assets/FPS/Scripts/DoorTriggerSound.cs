using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerSound : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    private float timer;
    bool isOpened=false;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;
      if (timer >=3 && isOpened ==false){
        isOpened = true;
        m_MyAudioSource.Play();
      }
    }
}
