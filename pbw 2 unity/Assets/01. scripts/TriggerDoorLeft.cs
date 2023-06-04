using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorLeft : MonoBehaviour
{
    [SerializeField] GameObject doorBlock;

    bool isOpened = false;

    int x = 1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !isOpened)
        {
            Debug.Log("chick in place");
            isOpened = true;
            doorBlock.transform.position += new Vector3(x, 0, 0);
        }
    }
}
