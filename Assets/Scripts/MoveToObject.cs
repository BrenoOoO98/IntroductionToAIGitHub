using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class MoveToObject : MonoBehaviour
{
    public Transform Target;
    private UnityEngine.AI.NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
      _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();  
    }

    // Update is called once per frame
    void Update()
    {
      _agent.destination = Target.position;  
    }
}
