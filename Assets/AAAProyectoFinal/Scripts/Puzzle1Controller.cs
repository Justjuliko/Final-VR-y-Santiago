using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Controller : MonoBehaviour
{
    [SerializeField] float energyValue = 0;

    public GameObject unlockable1;
    public GameObject unlockable2;

    public GameObject lampObject1;
    public GameObject lampObject2;

    [SerializeField] bool generatorController;
    [SerializeField] bool doorController;
    [SerializeField] bool lightController;

    public void generatorON()
    {
        generatorController = true;
        energyValue = 1;
    }
    public void generatorOFF()
    {
        generatorController = false;
        energyValue = 0;
    }
    public void doorON()
    {
        if (energyValue == 1)
        {
            doorController = true;
            energyValue = 0;
            unlockDoor();
        }       
    }
    public void doorOFF()
    {
        doorController = false;
        energyValue = 1;
        lockDoor();
    }
    public void lightON()
    {
        if (energyValue == 1) 
        {
            lightController = true;
            energyValue = 0;
            turnOnLights();
        }
    }
    public void lightOFF()
    {
        lightController = false;
        energyValue = 1;
        turnOffLights();
    }
    public void unlockDoor()
    {
        unlockable1.SetActive(false);
        unlockable2.SetActive(false);
    }
    public void lockDoor()
    {
        unlockable1.SetActive(true);
        unlockable2.SetActive(true);
    }
    public void turnOnLights()
    {
        lampObject1.SetActive(true);
        lampObject2.SetActive(true);
    }
    public void turnOffLights()
    {
        lampObject1.SetActive(false);
        lampObject2.SetActive(false);
    }
}
