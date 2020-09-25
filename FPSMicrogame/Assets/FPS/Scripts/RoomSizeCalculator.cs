using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSizeCalculator : MonoBehaviour
{
  private float roomRoof;
  private float roomFloor;
  private float roomHeight;

  private float roomForward;
  private float roomBack;
  private float roomDepth;

  private float roomLeft;
  private float roomRight;
  private float roomWidth;

  private float roomSize;
  private float newRoomSize=0f;
  private int roomSizeDelay=0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RoomHeight();
        RoomDepth();
        RoomWidth();
        roomSize=roomHeight * roomDepth*roomWidth;
        if(roomSize<newRoomSize-1000 ||roomSize>newRoomSize+1000){
            roomSizeDelay+=1;
            if (roomSizeDelay>=20){
              newRoomSize=roomSize;
              roomSizeDelay=0;
            }
        }
        if(roomSize>=newRoomSize-1000 && roomSize<=newRoomSize+1000){
          roomSizeDelay=0;
        }
        Debug.Log("FAST: "+roomSize+"   "+"ACTUAL: "+newRoomSize);
    }

    private void RoomHeight(){
      Vector3 transformDown = transform.up * -1;
      int layerMask = 1<< 13;
      RaycastHit hitHeight;
      RaycastHit hitFloor;
      if  (Physics.Raycast(transform.position, transform.up, out hitHeight, Mathf.Infinity, layerMask))
      {
        roomRoof= hitHeight.distance;
      }
      if  (Physics.Raycast(transform.position, transformDown, out hitFloor, Mathf.Infinity))
      {
        roomFloor= hitFloor.distance;
      }
      roomHeight = roomRoof +roomFloor;
    }

    private void RoomDepth(){
      Vector3 transformBack = transform.forward * -1;
      int layerMask = 1<< 13;
      RaycastHit hitForward;
      RaycastHit hitBack;
      if  (Physics.Raycast(transform.position, transform.forward, out hitForward, Mathf.Infinity, layerMask))
      {
        roomForward= hitForward.distance;
      }
      if  (Physics.Raycast(transform.position, transformBack, out hitBack, Mathf.Infinity, layerMask))
      {
        roomBack= hitBack.distance;
      }
      roomDepth = roomForward +roomBack;
    }

    private void RoomWidth(){
      Vector3 transformLeft = transform.right * -1;
      int layerMask = 1<< 13;
      RaycastHit hitRight;
      RaycastHit hitLeft;
      if  (Physics.Raycast(transform.position, transform.right, out hitRight, Mathf.Infinity, layerMask))
      {
        roomRight= hitRight.distance;
      }
      if  (Physics.Raycast(transform.position, transformLeft, out hitLeft, Mathf.Infinity, layerMask))
      {
        roomLeft= hitLeft.distance;
      }
      roomWidth = roomLeft+roomRight;
    }
}
