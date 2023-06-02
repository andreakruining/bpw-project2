using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorLeft : MonoBehaviour
{
    [SerializeField] GameObject door;

    bool isOpened = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !isOpened)
        {
            Debug.Log("chick in place");
            isOpened = true;
            door.transform.position += new Vector3(1, 0, 0);
        }
    }
}
