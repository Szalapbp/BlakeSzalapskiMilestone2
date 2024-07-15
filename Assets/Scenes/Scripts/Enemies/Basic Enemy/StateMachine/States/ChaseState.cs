using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : StateMachine
{
    public ChaseState(Enemy enemy) : base(enemy) { }
    public override void Enter()
    {

    }



    public override void Update()
    {
        float distanceToPlayer = Vector3.Distance(enemy.transform.position, enemy.player.position);

        if (distanceToPlayer < enemy.chaseDistance)
        {
            enemy.navMeshAgent.SetDestination(enemy.player.position);
        }
        else
        {
            enemy.ChangeState(new IdleState(enemy));
        }
    }
    public override void Exit()
    {
        enemy.navMeshAgent.ResetPath();

    }
}
