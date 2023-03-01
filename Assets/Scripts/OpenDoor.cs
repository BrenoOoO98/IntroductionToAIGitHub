using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public float speed = 3f;
    public float WaitTime = 5f;
	public Vector3 PositionDelta =Vector3.zero;

    private Vector3 _closedPosition;
    private Vector3 _openPosition;
    // Start is called before the first frame update
    void Start()
    {
      _closedPosition = transform.position;
      _openPosition = _closedPosition + PositionDelta;

    }
   IEnumerator OpenClose()
   {
    
     Vector3 goal = _openPosition;
     bool isOpen = false;
     while(true)
     {
      if (Vector3.Distance(transform.position, _openPosition) <0.1f)
      {
          isOpen =!isOpen;
          if (isOpen)
          {
                goal = _closedPosition;
          }
          else
          {
                goal = _openPosition;
          }
          yield return new WaitForSeconds(WaitTime);
      }
      else
      {
        transform.position = Vector3.MoveTowards(transform.position, _openPosition, speed * Time.deltaTime);
      yield return null;
      }
     
      ;
     }
    }

    // Update is called once per frame
}
   
