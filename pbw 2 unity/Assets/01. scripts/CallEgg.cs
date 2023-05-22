using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallEgg : MonoBehaviour
{
    public float callSpeed = 5f;
    public Rigidbody rb;
    public Transform player;

    public GameObject plank;

    private Animator animator;

    void Start()
    {
        animator = plank.GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKey("c"))
        {
            Vector3 actualTarget = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
            //rb.velocity = Vector3.zero; 

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, callSpeed * Time.deltaTime);
        }

        if (Input.GetKey("v"))
        {
            //Vector3 actualTarget = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
            rb.velocity = transform.right * 10;
            
            //transform.position = Vector3.MoveTowards(transform.position, -player.transform.position, callSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision plankFall)
    {
        if (plankFall.gameObject.CompareTag("Plank"))
        {
            animator.SetTrigger("fallingDown");
        }
    }
}
