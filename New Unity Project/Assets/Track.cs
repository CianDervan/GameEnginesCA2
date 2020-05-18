using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Track : MonoBehaviour
{

    public float lookRadius = 5f;
    Transform targetMe;
    NavMeshAgent agent;

    private void Start()
    {
        targetMe = Player_Manager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(targetMe.position, transform.position);

        if (distance <= lookRadius )
        {
            transform.position = targetMe.position;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
