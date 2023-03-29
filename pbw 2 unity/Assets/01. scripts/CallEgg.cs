using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallEgg : MonoBehaviour
{
    public float callSpeed= 5f;
    public Rigidbody rb;
    // public GameObject egga;
    public GameObject player;

    //Vector3 goalPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = transform.position;

        if(Input.GetKey("c"))
        {
            Debug.Log("mouse");
           
            rb.velocity = Vector3.zero; 

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, callSpeed * Time.deltaTime);

        }
        //transform.position = position;
    }
}
