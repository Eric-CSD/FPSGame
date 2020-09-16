using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private GameObject Enemy1;
    [SerializeField] private GameObject Enemy2;
    bool isOpened = false;
    private Animator animator;

    private void Awake(){
      animator = GetComponent<Animator>();
      animator.SetBool("Open", false);
    }

    private void Update()
    {
      if (Enemy1 == null && Enemy2 == null && isOpened ==false){
        Debug.Log("Test 2 enemies");
        isOpened = true;
        animator.SetBool("Open", true);
      }

    }
}
