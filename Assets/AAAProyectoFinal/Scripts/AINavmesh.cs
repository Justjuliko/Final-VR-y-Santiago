using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINavmesh : MonoBehaviour
{
    [SerializeField] Transform movePos;
    private NavMeshAgent agent;
    Animator animator;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        agent.destination = movePos.position;

        animator.SetFloat("Move", agent.velocity.magnitude);
    }
    public void UpdatePos(Vector3 newPos)
    {
        movePos.position = newPos;
    }
}
