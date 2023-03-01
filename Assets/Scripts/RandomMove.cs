using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class RandomMove : MonoBehaviour
{
   NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
      _agent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
      if(Vector3.Distance(_agent.destination, transform.position)< 2f)  
     {
      float randomX = Random.range(-5f,5f)
      float randomZ = Ramdom.range(-5f,5f)

      Vector3 randomPosition = new Vector3(transform.psotion.x + randomX, transform.positon.y, transform.position.z + randomZ);
      _agent.destination = randomPosition;
     }
    }
}
