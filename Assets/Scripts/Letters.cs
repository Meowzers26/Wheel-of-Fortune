using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Letters : MonoBehaviour
{

    public bool inUse = false;
    public Material lettersInUse;
    public Material lettersInDisuse;
    public TextMeshPro outputLetter;
    public TMP_InputField inputLetter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inUse == true) {
            GetComponent<MeshRenderer>().material = lettersInUse;

            outputLetter.text = inputLetter.text;

        } else {
            GetComponent<MeshRenderer>().material = lettersInDisuse;
        }
    }
}
