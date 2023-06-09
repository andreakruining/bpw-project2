using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMove : MonoBehaviour
{
    private float Speed = 5f;

    public Rigidbody rb_P;

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
        transform.position = position;
    }
}
