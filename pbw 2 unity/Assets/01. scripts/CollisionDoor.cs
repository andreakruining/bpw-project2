using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if(collision.GetComponent<Collider>().tag == "Door")
        {
            Debug.Log("Button");
        }
    }

}
