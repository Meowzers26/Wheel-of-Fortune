using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float genSpeed;
    public float subSpeed;
    public bool isSpinning = false;
    public bool buttonClicked = false;
    private bool triggerCelebrate = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isSpinning == true) {
            transform.Rotate(0, genSpeed, 0, Space.World);
            genSpeed -= subSpeed;
        }

        if (genSpeed <= 0) {
            genSpeed = 0;
            isSpinning = false;
        }
    }

    public void spinWheel() {
        genSpeed = Random.Range(5.000f, 9.000f);
        subSpeed = Random.Range(0.013f, 0.019f);
        isSpinning = true;
        buttonClicked = true;
    }
}
