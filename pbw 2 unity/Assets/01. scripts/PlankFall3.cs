using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankFall3 : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
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
