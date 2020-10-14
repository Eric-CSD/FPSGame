using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoorTriggerFinal : MonoBehaviour
{
    [SerializeField] private GameObject Enemy1;
    [SerializeField] private GameObject Enemy2;
    [SerializeField] private GameObject Enemy3;
    [SerializeField] private GameObject Enemy4;
    [SerializeField] private GameObject Enemy5;
    // [SerializeField] private GameObject Enemy2;
    public bool isOpened = false;
    private Animator animator;

    private void Awake(){
      animator = GetComponent<Animator>();
      animator.SetBool("Open2", false);
    }

    private void Update()
    {
      if (Enemy1 == null && Enemy2 == null && Enemy3 == null && Enemy4 == null && Enemy5 == null && isOpened ==false){
        Debug.Log("GitHubPushPullTest");
        isOpened = true;
        animator.SetBool("Open2", true);
      }

    }
}
