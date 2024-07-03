using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeranimation : MonoBehaviour
{
    
    private Animator animator;
    public Spinner ws;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator != null) {
            if (isSpinning == false && buttonClicked == true) {
                animator.SetBool("celebrate", true);
            }

            else {
                animator.SetBool("celebrate", false);
            }
        }

    }
}
