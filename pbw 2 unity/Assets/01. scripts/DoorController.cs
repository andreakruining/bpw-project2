using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Egg"))
        {
            if(openTrigger)
            {
                myDoor.Play("DoorOpening", 0, 0.0f);
                gameObject.SetActive(false);
            }

            else if(closeTrigger)
            {
                myDoor.Play("DoorClosing", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
