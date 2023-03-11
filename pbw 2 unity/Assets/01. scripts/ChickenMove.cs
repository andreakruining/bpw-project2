using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour
{
 
    public float Speed = 5f;
    public float JumpForce = 5f;

    public GameObject egga;
    public GameObject plank;
    private Rigidbody plankRB;

    void Start()
    {
        plankRB = plank.GetComponent<Rigidbody>();
        plankRB.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector3 position = transform.position;

        if(Input.GetKey("a"))
        {
            position.x -= Speed * Time.deltaTime;
        }

        transform.position = position;
        
        if(Input.GetKey("d"))
        {
            position.x += Speed * Time.deltaTime;
        }

        transform.position = position;

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
            egga.gameObject.transform.localScale = new Vector3(1, 0, 1);
            JumpForce += 2f;
        }

    }

    private void OnCollisionEnter(Collision plankFall)
    {
        if(plankFall.collider.tag == "Plank")
        {
            Debug.Log("fall");
            plankRB.useGravity = true;
        }
    } 
}
