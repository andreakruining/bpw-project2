using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
    public GameObject log;
    public Transform targetPos;

    public float speed = 2f;


    public void OnTriggerEnter(Collider crossing)
    {

        if (crossing.CompareTag("Egg"))
        {
            log.transform.position = Vector3.Lerp(transform.position, targetPos.transform.position, speed * Time.deltaTime);
        }
    }
}
