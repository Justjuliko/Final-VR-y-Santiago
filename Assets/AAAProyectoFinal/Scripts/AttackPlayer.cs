using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackPlayer : MonoBehaviour
{
    SphereCollider attackCol;
    [SerializeField] AudioSource screamSound;
    [SerializeField] string scene;

    private void OnTriggerEnter(Collider GameObject)
    {
        if(GameObject.CompareTag("Player"))
        {
            screamSound.Play();
            SceneManager.LoadScene(scene);
        }
    }
}
