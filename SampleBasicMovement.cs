using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleBasicMovement : MonoBehaviour
{

    public Animator animator;

    Vector3 movement;
    void Update()
    {
        ProcessInput();

        if (Input.GetButtonUp("Attack")){
            animator.SetTrigger("Attack");
        }

        if (Input.GetButtonUp("Pick Up")){
            animator.SetTrigger("Pick Up");
        }
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        transform.position = transform.position + movement * Time.deltaTime;
    }

    private void ProcessInput()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
    }
}
