using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMove : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpForce = 5f;

    public GameObject egga;
    public Rigidbody rb;
    float movement; 

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void FixedUpdate()
    {
        //rb.MovePosition = movement * speed * Time.fixedDeltaTime;
        transform.Translate(movement, 0, 0);
    }

    public void Move()
    {
        Vector3 position = transform.position;
        movement = Input.GetAxis("Horizontal");

        // if(Input.GetKey("a"))
        // {
        //     position.x -= Speed * Time.deltaTime;
        //     transform.Rotate(Vector3.up * Speed * Time.deltaTime);
        // }

        // if(Input.GetKey("d"))
        // {
        //     position.x += Speed * Time.deltaTime;
        //     transform.Rotate(-Vector3.up * Speed * Time.deltaTime);
        // }

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
        }
    }
}
