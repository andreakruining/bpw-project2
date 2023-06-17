using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallEgg : MonoBehaviour
{
    public float callSpeed = 5f;
    public Rigidbody rb;
    public Transform player;

    public AudioSource chickenNoise;
    public AudioSource cPress;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKey("c"))
        {
            rb.velocity = new Vector3(-5, 0, 0);
            cPress.Play();
            //Vector3 actualTarget = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
            ////rb.velocity = Vector3.zero; 

            //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, callSpeed * Time.deltaTime);
        }

        if (Input.GetKey("v"))
        {
            //Vector3 actualTarget = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
            rb.velocity = transform.right * 5;
            chickenNoise.Play();
            
            //transform.position = Vector3.MoveTowards(transform.position, -player.transform.position, callSpeed * Time.deltaTime);
        }
    }


}
