using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMove : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpForce = 5f;

    public GameObject egga;
    // public Rigidbody rb;
    // Vector3 movement; 

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // void FixedUpdate()
    // {
    //     //rb.MovePosition = movement * Speed * Time.fixedDeltaTime;
    //     //rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
    //     //transform.Translate(0, 0, movement + Speed * Time.fixedDeltaTime);
    //     Vector3 direction = movement.normalized;
    //     rb.MovePosition(rb.position + direction * Speed * Time.fixedDeltaTime);
    // }

    public void Move()
    {
        Vector3 position = transform.position;
        //movement.z = Input.GetAxis("Horizontal");

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
            position.y += JumpForce * Time.deltaTime;
        }

        transform.position = position;
    }

    private void OnTriggerEnter(Collider springen)
    {

        if(springen.GetComponent<Collider>().tag == "Egg")
        {
            Debug.Log("plat egg");
            //egga.gameObject.transform.localScale = new Vector3(1, 0, 1);
            JumpForce += 5f;
            if(JumpForce >=15)
            {
                JumpForce = 5f;   
            }
        }
    }
}
