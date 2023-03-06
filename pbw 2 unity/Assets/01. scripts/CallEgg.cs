using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallEgg : MonoBehaviour
{
    public float callSpeed= 30f;
    //public Rigidbody rb;
    public GameObject egga;
    public GameObject player;

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
            egga.transform.position = Vector3.MoveTowards(egga.transform.position, player.transform.position, callSpeed * Time.deltaTime);
            //rb.AddForce(-callSpeed * Time.deltaTime,0,0);
            //position.x -= callSpeed * Time.deltaTime;
        }
        //transform.position = position;
    }
}
