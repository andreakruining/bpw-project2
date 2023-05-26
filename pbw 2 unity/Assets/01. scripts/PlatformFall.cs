using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
    public GameObject log;
    public Transform targetPos;

    //public float speed = 2f;

    private void Start()
    {
     
    }


    public void OnTriggerEnter(Collider crossing)
    {

        if (crossing.CompareTag("Egg"))
        {
            targetPos = log.transform;
            targetPos.transform.position = new Vector3(5.98f, 0.92f, 1.38f);
                
            //Vector3.MoveTowards(transform.position, targetPos.transform.position, speed * Time.deltaTime);
        }
    }
}
