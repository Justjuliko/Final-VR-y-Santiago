using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretObj : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    private void Update()
    {
        if(TimerOn) 
        { 
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
            }
            if (TimeLeft <= 0)
            {
                GameObject.Destroy(gameObject);
            }
        }
    }
    public void Timer()
    {
        TimerOn = true;
    }
}
