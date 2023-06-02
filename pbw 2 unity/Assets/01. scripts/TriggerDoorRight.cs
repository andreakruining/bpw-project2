using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorRight : MonoBehaviour
{
    [SerializeField] GameObject triggerBlock;

    bool isOpened = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Egg") && !isOpened)
        {
            Debug.Log("egg in place");
            isOpened = true;
            triggerBlock.transform.position += new Vector3(1, 0, 0);
        }
    }
}
