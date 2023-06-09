using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
    public GameObject log;
    public Transform targetPos;

    public void OnTriggerEnter(Collider crossing)
    {

        if (crossing.CompareTag("Egg"))
        {
            log.transform.position = targetPos.position;          
        }
    }
}
