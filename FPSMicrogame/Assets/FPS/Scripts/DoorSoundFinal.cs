using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSoundFinal : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    bool DoorSoundPlayed = false;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      if (GetComponent<DoorTriggerFinal>().isOpened == true && DoorSoundPlayed == false){
        Debug.Log("Test");
        m_MyAudioSource.Play();
        DoorSoundPlayed = true;

      }
    }
}
