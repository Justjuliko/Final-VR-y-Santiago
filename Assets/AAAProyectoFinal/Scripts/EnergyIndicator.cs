using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyIndicator : MonoBehaviour
{
    [SerializeField] Image Indicator;

    public void Green()
    {
        Indicator.color = Color.green;
    }
    public void Red()
    {
        Indicator.color = Color.red;
    }
}
