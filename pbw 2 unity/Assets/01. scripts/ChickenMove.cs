using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour
{
 
    public float Speed = 5f;
    public float JumpForce = 5f;

    public GameObject egga;
    public GameObject plank;
    //private Rigidbody plankRB;
    private Animator animator;

    private float delay = 2.5f;

    void Start()
    {
        // plankRB = plank.GetComponent<Rigidbody>();
        // plankRB.useGravity = false;
        animator = plank.GetComponent<Animator>();
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector3 position = transform.position;

        //dit is echt de enige die werkt. Met rigidbody krijg ik alleen maar meer bugs die niet willen oplossen
        if(Input.GetKey("a"))
        {
            position.x -= Speed * Time.deltaTime;
        }
        
        if(Input.GetKey("d"))
        {
            position.x += Speed * Time.deltaTime;
        }

        if(Input.GetKey("space"))
        {
            position.y += JumpForce * Time.deltaTime;
        }

        transform.position = position;
    }

    private void OnTriggerEnter(Collider springen)
    {

        if(springen.CompareTag("Egg"))
        {
            StartCoroutine(TriggeredEvent());
        }
    }

    private IEnumerator TriggeredEvent()
    {
        Debug.Log("event started");

        JumpForce += 5f;
        yield return new WaitForSeconds(delay);

        Debug.Log("event ended");
        JumpForce = 5f;
    }

    private void OnCollisionEnter(Collision plankFall)
    {
        if(plankFall.gameObject.CompareTag("Plank"))
        {
            animator.SetTrigger("fallingDown");
        }
    } 
}
