using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMove : MonoBehaviour
{
    private float Speed = 5f;
    private float JumpForce = 1.5f;

    //public GameObject egga;
    public Rigidbody rb_P;

    //private float delay = 2.5f;

    //public AudioSource audioSource;

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
            transform.Rotate(Vector3.up * Speed * Time.deltaTime);
        }

        if(Input.GetKey("d"))
        {
            position.x += Speed * Time.deltaTime;
            transform.Rotate(-Vector3.up * Speed * Time.deltaTime);
        }

        if(Input.GetKey("space"))
        {
            rb_P.velocity = transform.up * JumpForce;
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
}
