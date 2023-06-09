using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankFall3 : MonoBehaviour
{
    //play animation for plank in third level on collision with the egg
    private Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }
    private void OnCollisionEnter(Collision plankFall)
    {
        if (plankFall.gameObject.CompareTag("Egg"))
        {
            animator.SetTrigger("Fall3");
        }
    }
}
