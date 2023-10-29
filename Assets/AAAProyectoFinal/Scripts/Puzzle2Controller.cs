using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2Controller : MonoBehaviour
{
    public GameObject code;
    [SerializeField] bool codeVisible;

    public void ShowCode()
    {
        code.SetActive(true);
        codeVisible = true;
    }
    public void HideCode()
    {
        code.SetActive(false);
        codeVisible = false;
    }
}
