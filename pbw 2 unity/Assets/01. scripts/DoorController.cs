using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator Door = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {

        if(other.GetComponent<Collider>().tag == "Egg")
        {
            Debug.Log("button");

            if(openTrigger)
            {
                Door.Play("DoorOpening", 0, 0.4f);
                gameObject.SetActive(true);
            }

            else if(closeTrigger)
            {
                Door.Play("DoorClosing", 0, 0.4f);
                gameObject.SetActive(true);
            }
        }
    }
}
