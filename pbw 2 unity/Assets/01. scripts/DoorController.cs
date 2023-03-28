using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator Door = null;

    private GameObject fence;

    // [SerializeField] private bool openTrigger = false;
    // [SerializeField] private bool closeTrigger = false;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider openen)
    {
        if(openen.GetComponent<Collider>().tag == "Egg")
        {
            Debug.Log("open");
            Door.SetTrigger("OpenTrigger");
            //fence.GetComponent<Collider2D>().enabled = false;
        }
    }

    // private void OnTriggerExit(Collider sluiten)
    // {
    //         Debug.Log("close");
            
    //         Door.SetTrigger("OpenTrigger");
    // }
}
