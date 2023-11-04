using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetThrowable : MonoBehaviour
{
    public GameObject throw1;
    public GameObject throw2;
    public GameObject throw3;

    public Vector3 initialPos1;
    public Vector3 initialPos2;
    public Vector3 initialPos3;

    private void Start()
    {
        initialPos1 = throw1.transform.position;
        initialPos2 = throw2.transform.position;
        initialPos3 = throw3.transform.position;
    }
    public void ResetPosThrowables()
    {
        throw1.transform.position = initialPos1;
        throw2.transform.position = initialPos2;
        throw3.transform.position = initialPos3;
    }
}
