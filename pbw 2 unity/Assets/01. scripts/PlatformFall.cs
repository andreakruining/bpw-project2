using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
    public GameObject log;
    float x = 6;
    float y = 1;
    float z = 2;


    public void OnTriggerEnter(Collider crossing)
    {

        if (crossing.CompareTag("Egg"))
        {
            log.transform.position = new Vector3(x, y, z);
        }
    }
}
