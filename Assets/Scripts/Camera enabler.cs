using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraenabler : MonoBehaviour
{

    public Camera puzzle;
    public Camera iso;
    public Camera wheel;

    public bool puzzleOn;
    public bool isoOn;
    public bool wheelOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleOn == true) {
            puzzle.GetComponent<Camera>().enabled = true;
        }

        if (isoOn == true) {
            iso.GetComponent<Camera>().enabled = true;
        }

        if (wheelOn == true) {
            wheel.GetComponent<Camera>().enabled = true;
        }
    }
}
