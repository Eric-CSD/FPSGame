using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoorTriggerStart : MonoBehaviour
{
    // [SerializeField] private GameObject Enemy1;
    // [SerializeField] private GameObject Enemy2;
    bool isOpened = false;
    private Animator animator;
    private float timer;

    private void Awake(){
      animator = GetComponent<Animator>();
      animator.SetBool("OpenStart", false);
    }

    private void Update()
    {
      timer += Time.deltaTime;
      if (timer >=3 && isOpened ==false){
        Debug.Log("GitHubPushPullTest");
        isOpened = true;
        animator.SetBool("OpenStart", true);
      }

    }
}
