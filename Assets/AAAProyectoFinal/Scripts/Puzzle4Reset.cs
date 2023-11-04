using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle4Reset : MonoBehaviour
{
    [SerializeField] GameObject PlayerCamera;
    [SerializeField] GameObject PlayerPseudoBody;
    [SerializeField] GameObject respawnPoint;

    public void ResetPlayerPos()
    {
        PlayerCamera.transform.position = respawnPoint.transform.position;
        PlayerPseudoBody.transform.position = respawnPoint.transform.position;
    }
}
