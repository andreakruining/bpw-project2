using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour
{
 
            public float Speed = 5f;

    public void Update()
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

        if(Input.GetKey("w"))
        {
            position.z += Speed * Time.deltaTime;
        }

        transform.position = position;

        if(Input.GetKey("s"))
        {
            position.z -= Speed * Time.deltaTime;
        }

        transform.position = position;
    }

}
