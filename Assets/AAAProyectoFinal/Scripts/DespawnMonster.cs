using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnMonster : MonoBehaviour
{
    [SerializeField] GameObject Monster;
    bool destroyed = false;

    public void monsterDespawn()
    {
        if (destroyed == false)
        {
            Destroy(Monster);
            destroyed = true;
        }           
        else if(destroyed == true)
        {
            Debug.Log("Already destroyed AI");
        }
    }
}
