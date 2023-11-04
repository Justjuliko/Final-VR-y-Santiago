using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretObj : MonoBehaviour
{
    [SerializeField] GameObject unlockable1;
    [SerializeField] GameObject unlockable2;

    [SerializeField] AudioSource collectSecretSound;
    [SerializeField] int count = 0;

    public void collectSecret()
    {
        collectSecretSound.Play();
        count++;
    }
    private void Update()
    {
        if (count == 3)
        {
            unlockable1.SetActive(false);
            unlockable2.SetActive(false);
        }
        if (count >= 3)
        {
            count = 3;
        }
        else
        {
            unlockable1.SetActive(true); 
            unlockable2.SetActive(true);
        }
    }
}
