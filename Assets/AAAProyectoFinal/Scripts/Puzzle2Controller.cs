using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puzzle2Controller : MonoBehaviour
{
    public GameObject code;
    [SerializeField] bool codeVisible;
    [SerializeField] GameObject canvas;

    string Code = "623";
    string Nr = null;
    int NrIndex = 0;
    string alpha;
    public TMP_Text UIText = null;

    public GameObject unlockable3;
    public GameObject unlockable4;

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
    public void CodeFunction(string Numbers)
    {
        NrIndex++;
        Nr = Nr + Numbers;
        UIText.text = Nr;
    }
    public void EnterCode()
    {
        if (Nr == Code)
        {
            unlockable3.SetActive(false);
            unlockable4.SetActive(false);
            canvas.SetActive(false);
        }
        else 
        {
            NrIndex++;
            Nr = null;
            UIText.text = Nr;
        }
    }
    public void DeleteCode()
    {
        NrIndex++;
        Nr = null;
        UIText.text = Nr;
    }
}
