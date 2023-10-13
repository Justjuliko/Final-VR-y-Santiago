using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BaloncestoTrigger : MonoBehaviour
{
    int score = 0;
    public TMP_Text scoreText; 
    public void OnTriggerEnter(Collider other)
    {
        score++;
    }
    void Start()
    {
        
    }

    void Update()
    {       
        scoreText.text = score.ToString(); 
    }
}
