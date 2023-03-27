using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMove : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpForce = 5f;

    public GameObject egga;
    private float horizontal;
    private float vertical;
    public Rigidbody rb;

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
        rb.MovePosition(transform.position + horizontal * Speed * Time.deltaTime);
        rb.MovePosition(transform.position + vertical * Speed * Time.deltaTime);
    }

    public void Move()
    {
        Vector3 position = transform.position;
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

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
