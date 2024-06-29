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
            iso.GetComponent<Camera>().enabled = false;
            wheel.GetComponent<Camera>().enabled = false;
        }

        if (isoOn == true) {
            iso.GetComponent<Camera>().enabled = true;
            puzzle.GetComponent<Camera>().enabled = false;
            wheel.GetComponent<Camera>().enabled = false;
        }

        if (wheelOn == true) {
            wheel.GetComponent<Camera>().enabled = true;
            iso.GetComponent<Camera>().enabled = false;
            puzzle.GetComponent<Camera>().enabled = false;
        }
    }
}
