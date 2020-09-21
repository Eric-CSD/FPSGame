using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private GameObject Enemy1;
    // [SerializeField] private GameObject Enemy2;
    bool isOpened = false;
    private Animator animator;

    private void Awake(){
      animator = GetComponent<Animator>();
      animator.SetBool("Open1", false);
    }

    private void Update()
    {
      if (Enemy1 == null && isOpened ==false){
        // Debug.Log("GitHubPushPullTest");
        isOpened = true;
        animator.SetBool("Open1", true);
      }

    }
}
