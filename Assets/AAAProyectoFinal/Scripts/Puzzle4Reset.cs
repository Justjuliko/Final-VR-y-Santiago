using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle4Reset : MonoBehaviour
{
    Vector3 playerCamNewPos;
    Vector3 playerBodyNewPos;
    [SerializeField] GameObject PlayerCamera;
    [SerializeField] GameObject PlayerPseudoBody;
    [SerializeField] GameObject respawnPoint;

    public void ResetPlayerPos()
    {
        playerCamNewPos = new Vector3(respawnPoint.transform.position.x, PlayerCamera.transform.position.y, respawnPoint.transform.position.z);
        playerBodyNewPos = new Vector3(respawnPoint.transform.position.x, PlayerPseudoBody.transform.position.y, respawnPoint.transform.position.z);
        PlayerCamera.transform.position = playerCamNewPos;
        PlayerPseudoBody.transform.position = playerBodyNewPos;
        Debug.Log("Changing PlayerPos");
    }
}
