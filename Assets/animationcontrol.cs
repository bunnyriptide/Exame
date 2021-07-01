using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontrol : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;

    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool animWalking = animator.GetBool(isWalkingHash);

        if (!animWalking && Input.GetKey("w"))
        {
            animator.SetBool(isWalkingHash, true);
        }
        else if (!animWalking && Input.GetKey("a"))
        {
            animator.SetBool(isWalkingHash, true);
        }
        else if (!animWalking && Input.GetKey("s"))
        {
            animator.SetBool(isWalkingHash, true);
        }
        else if (!animWalking && Input.GetKey("d"))
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (animWalking && !Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("d"))
        {
            animator.SetBool(isWalkingHash, false);
        }
    }
}
