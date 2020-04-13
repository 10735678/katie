using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Patrol", menuName = "Ai/Function/Patrol")]
public class AiPatrol : AiBase
{
    public GameAction addPointList;
    [HideInInspector] public List<Vector3Data> patrolPoints;
    private int i;
    
    private void OnEnable()
    {
        patrolPoints?.Clear();
        
        i = 0;
    }

    private void OnDisable()
    {
        patrolPoints?.Clear();
    }

    private void AddPatrolPointList(object obj)
    {
        patrolPoints = obj as List<Vector3Data>;
    }
    
    public void RunAgent(NavMeshAgent agent)
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            agent.destination = patrolPoints[i].value;
            i = (i + 1) % patrolPoints.Count;
        }
    }
}

public class Vector3Data
{
    public Vector3 value;
}

public class GameAction
{
    public object raise;
}

public class AiBase
{
}
