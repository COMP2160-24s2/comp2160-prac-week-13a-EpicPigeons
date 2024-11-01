using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class DroneFollow : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float minDistance = 5f;
    private NavMeshAgent agent;
    private Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        destination = target.transform.position;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target.transform.position) >= minDistance)
        {
            agent.SetDestination(destination);
        } 
        else 
        {
            agent.SetDestination(transform.position);
        }
        destination = target.transform.position;
    }
}
