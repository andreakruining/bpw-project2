using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassBlockCollider : MonoBehaviour
{
    public GameObject grass;
    public Transform targetpos;
    private void OnTriggerEnter(Collider blockFall)
    {
        if (blockFall.CompareTag("Player"))
        {
            targetpos = grass.transform;
            grass.transform.position = new Vector3(19.56f, -0.06f, 1.07f);
        }
    }
}