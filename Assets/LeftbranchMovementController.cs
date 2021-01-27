using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftbranchMovementController : MonoBehaviour
{
    Animator animator;
    
    int isWavingHash;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //Increasing Preformance
       
        isWavingHash = Animator.StringToHash("isWaving");
     

    }

    // Update is called once per frame
    void Update()
    {
      
        bool isWaving = animator.GetBool(isWavingHash);
        
        bool waving = Input.GetKey("1");
       


        // When Button 1 Is Pressed.
        if (!isWaving && waving)
        {
            // Setting isWaving1 Boolean To True.
            animator.SetBool(isWavingHash, true);

        }
        // When Button 1 Isn't Pressed.
        if (isWaving && !waving)
        {
            // Setting isWaving1 Boolean To False.
            animator.SetBool(isWavingHash, false);

        }


    }
}

