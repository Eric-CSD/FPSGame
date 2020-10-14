using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusicScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool endBossStart = false;
    public AudioSource _AudioSource;
    public AudioSource _AudioSource2;
    public AudioClip _AudioClip1;
    public AudioClip _AudioClip2;

    void Start()
    {

        _AudioSource.clip = _AudioClip1;
        _AudioSource.Play();
    }

    private void OnTriggerEnter(Collider Player)
    {
      if (endBossStart==false)
      {
        endBossStart =  true;
        _AudioSource2.Play();
        _AudioSource.clip = _AudioClip2;
        _AudioSource.Play();
      }

    }


    // void Update ()
    // {
    //
    //     if (Input.GetKeyDown(KeyCode.S))
    //     {
    //
    //         if (_AudioSource.clip == _AudioClip1)
    //         {
    //
    //             _AudioSource.clip = _AudioClip2;
    //
    //             _AudioSource.Play();
    //
    //         }
    //
    //         else
    //         {
    //
    //             _AudioSource.clip = _AudioClip1;
    //
    //             _AudioSource.Play();
    //
    //         }
    //
    //     }
    //
    // }
}
