using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorLeft : MonoBehaviour
{
    [SerializeField] GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player")) return;
        door.transform.position += new Vector3(1, 0, 0);
    }
}
