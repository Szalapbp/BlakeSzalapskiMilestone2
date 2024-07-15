using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float chaseDistance;
    public NavMeshAgent navMeshAgent;

    private StateMachine currentState;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        ChangeState(new IdleState(this));
    }

    void Update()
    {
        currentState?.Update();
    }

    public void ChangeState(StateMachine newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }
}
