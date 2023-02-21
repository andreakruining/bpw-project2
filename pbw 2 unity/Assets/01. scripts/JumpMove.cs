using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMove : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
}
