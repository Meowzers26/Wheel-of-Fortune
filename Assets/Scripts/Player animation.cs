using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeranimation : MonoBehaviour
{
    
    private Animator animator;
    public Spinner ws;
    public float celebrateTimerInit = 4.9f;
    public float celebrateTimer = 4.9f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (ws.isSpinning == false && ws.buttonClicked == true) {
            animator.SetBool("celebrate", true);
            celebrateTimer -= Time.deltaTime;

            if (celebrateTimer <= 0) {
                animator.SetBool("celebrate", false);
                ws.buttonClicked = false;
                celebrateTimer = celebrateTimerInit;
            }
        }

    }
}
