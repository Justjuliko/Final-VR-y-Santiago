using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackPlayer : MonoBehaviour
{
    [SerializeField] Puzzle4Reset puzzle4;

    SphereCollider attackCol;
    [SerializeField] AudioSource screamSound;

    private void OnTriggerEnter(Collider GameObject)
    {
        if(GameObject.CompareTag("Player"))
        {
            puzzle4.ResetPlayerPos();
        }
    }
    private void OnTriggerStay(Collider GameObject)
    {
        if (GameObject.CompareTag("Player"))
        {
            puzzle4.ResetPlayerPos();
        }        
    }
}
