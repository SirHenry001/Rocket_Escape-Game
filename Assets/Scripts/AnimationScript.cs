using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") < 0)
        {
            animator.SetBool("TurnLeft", true);
        }

        else
        {
            animator.SetBool("TurnLeft", false);
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            animator.SetBool("TurnRight", true);
        }

        else
        {
            animator.SetBool("TurnRight", false);
        }
    }
}
