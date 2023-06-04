using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour
{
 
    private float Speed = 5f;
    private float JumpForce = 2f;

    public Rigidbody rb_P;

    //public GameObject egga;
    //public GameObject plank;
 
    //private Animator animator;

    //private float delay = 1f;

    //public AudioSource audioSource;

    //void Start()
    //{
    //    animator = plank.GetComponent<Animator>();
    //}

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

        if (Input.GetKeyDown("space"))
        {
            rb_P.velocity = transform.up * JumpForce;
            //position.y += JumpForce * Time.deltaTime;
        }

        transform.position = position;
    }

    //private void OnTriggerEnter(Collider springen)
    //{

    //    if(springen.CompareTag("Egg"))
    //    {
    //        audioSource.Play();
    //        StartCoroutine(TriggeredEvent());
    //    }
    //}

    //private IEnumerator TriggeredEvent()
    //{
    //    Debug.Log("event started");

    //    JumpForce = 10f;
    //    yield return new WaitForSeconds(delay);

    //    Debug.Log("event ended");
    //    JumpForce = 5f;
    //}

    //private void OnCollisionEnter(Collision plankFall)
    //{
    //    if(plankFall.gameObject.CompareTag("Plank"))
    //    {
    //        animator.SetTrigger("fallingDown");
    //    }
    //} 

    //private IEnumerator Other()
    //{
    //    if (Input.GetKey("space"))
    //    {
    //        rb_P.velocity = transform.up * JumpForce;

    //        yield return new WaitForSeconds(5);

    //        rb_P.velocity = transform.up * 0;
    //        //position.y += JumpForce * Time.deltaTime;
    //    }
    //}
}
