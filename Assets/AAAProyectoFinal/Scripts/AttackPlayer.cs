using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackPlayer : MonoBehaviour
{
    [SerializeField] Puzzle4Reset puzzle4;
    [SerializeField] AINavmesh aiNav;

    SphereCollider attackCol;

    private void OnTriggerEnter(Collider GameObject)
    {
        if(GameObject.CompareTag("Player"))
        {
            puzzle4.ResetPlayerPos();
            aiNav.playerAsTarget = false;
        }
    }
    private void OnTriggerStay(Collider GameObject)
    {
        if (GameObject.CompareTag("Player"))
        {
            puzzle4.ResetPlayerPos();
            aiNav.playerAsTarget = false;
        }        
    }
}
