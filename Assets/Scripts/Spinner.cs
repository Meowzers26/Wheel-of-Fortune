using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float genSpeed;
    public float subSpeed;
    public bool isSpinning = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isSpinning == true) {
            transform.Rotate(0, genSpeed, 0, Space.World);
            genSpeed -= subSpeed;
        }
    }

    public void spinWheel() {
        genSpeed = Random.Range(2.000f, 5.000f);
        subSpeed = Random.Range(0.003f, 0.009f);
        isSpinning = true;
    }
}
