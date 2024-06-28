using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letters : MonoBehaviour
{

    public bool inUse = false;
    public Material lettersInUse;
    public Material lettersInDisuse;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inUse == true) {
            GetComponent<Renderer>().material = lettersInUse;
        } else {
            GetComponent<Renderer>().material = lettersInDisuse;
        }
    }
}
