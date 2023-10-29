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
    [SerializeField] bool lightController;
    [SerializeField] bool doorController;

    private void Update()
    {
        if (generatorController == true && lightController == false && doorController == true) 
        {
            unlockDoor();
        }
        else
        {
            lockDoor();
        }
    }
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
        if (generatorController == true) 
        {
            doorController = true;
            energyValue = 0;
        }
        
    }
    public void doorOFF()
    {
        if (generatorController == true)
        {
            doorController = false;
            energyValue = 1;
        }
            
    }
    public void lightON()
    {
        if (generatorController == true)
        {
            lightController = true;
            energyValue = 0;
            turnOnLights();
        }
            
    }
    public void lightOFF()
    {
        if (generatorController == true) 
        {
            lightController = false;
            energyValue = 1;
            turnOffLights();
        }
            
    }
    private void unlockDoor()
    {
        unlockable1.SetActive(false);
        unlockable2.SetActive(false);
    }
    private void lockDoor()
    {
        unlockable1.SetActive(true);
        unlockable2.SetActive(true);
    }
    private void turnOnLights()
    {
        lampObject1.SetActive(true);
        lampObject2.SetActive(true);
    }
    private void turnOffLights()
    {
        lampObject1.SetActive(false);
        lampObject2.SetActive(false);
    }
}
