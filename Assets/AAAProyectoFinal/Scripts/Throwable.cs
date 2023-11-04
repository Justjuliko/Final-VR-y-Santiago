using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    Vector3 pos;
    [SerializeField] AINavmesh AI;

    private void Start()
    {
        pos = transform.position;
    }
    private void OnTriggerEnter(Collider GameObject)
    {
        if (GameObject.CompareTag("Throwable"))
        {
            AI.UpdatePos(pos);
        }
    }
}
