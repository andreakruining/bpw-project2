using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallEgg : MonoBehaviour
{
    public float callSpeed= 3000f;
    public Rigidbody rb;

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
            rb.AddForce(-callSpeed * Time.deltaTime,0,0);
            //position.x -= callSpeed * Time.deltaTime;
        }
        //transform.position = position;
    }
}
