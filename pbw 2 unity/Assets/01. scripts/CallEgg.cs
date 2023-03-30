using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallEgg : MonoBehaviour
{
    public float callSpeed= 5f;
    public Rigidbody rb;
    public GameObject player;

    void Update()
    {
        if(Input.GetKey("c"))
        {
            rb.velocity = Vector3.zero; 

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, callSpeed * Time.deltaTime);
        }
    }
}
