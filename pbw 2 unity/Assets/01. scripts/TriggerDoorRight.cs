using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorRight : MonoBehaviour
{
    [SerializeField] GameObject triggerBlock;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Egg"))
        {
            Debug.Log("egg in place");
            triggerBlock.transform.position += new Vector3(1, 0, 0);
        }
    }
}
