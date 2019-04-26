// https://docs.unity3d.com/560/Documentation/Manual/nav-AgentPatrol.html
// code source

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class CastleGuardMovement : MonoBehaviour
{

    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private float wait = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = true;

        TravelToNext();

    }

    void TravelToNext()
    {
        if (!agent.isOnNavMesh)
            return;

        if (points.Length == 0)
        {
            return;
        }

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.isOnNavMesh)
            return;
        // make character wait to move until camera has attached
        wait += Time.deltaTime;
        if(wait >= 25)
        {
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
                TravelToNext();
        }

    }

}
