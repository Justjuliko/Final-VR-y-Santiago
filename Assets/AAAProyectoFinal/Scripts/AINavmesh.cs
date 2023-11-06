using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINavmesh : MonoBehaviour
{
    [SerializeField] Transform movePos;
    [SerializeField] Transform playerPos;
    private NavMeshAgent agent;
    Animator animator;
    public bool playerAsTarget = false;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (playerAsTarget==false)
        {
            agent.destination = movePos.position;
            animator.SetFloat("Move", agent.velocity.magnitude);
        }
        else if (playerAsTarget==true)
        {
            agent.destination = playerPos.position;
            animator.SetFloat("Move", agent.velocity.magnitude);
            agent.speed = 3;
        }
        
    }
    public void UpdatePos(Vector3 newPos)
    {
        movePos.position = newPos;
    }
    public void PlayerTarget()
    {
        playerAsTarget = true;
    }
}
