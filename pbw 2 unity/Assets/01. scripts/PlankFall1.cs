using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankFall1 : MonoBehaviour
{
    //play animation for plank in first level on collision with the egg

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision plankFall)
    {
        if (plankFall.gameObject.CompareTag("Egg"))
        {
            animator.SetTrigger("Fall1");
        }
    }
}
