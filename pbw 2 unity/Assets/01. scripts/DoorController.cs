using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator Door = null;

    public GameObject fence;


    // [SerializeField] private bool openTrigger = false;
    // [SerializeField] private bool closeTrigger = false;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider openen)
    {
        Collider fenceCollider = fence.GetComponent<Collider>();

        if(openen.GetComponent<Collider>().tag == "Egg")
        {
            Debug.Log("open");
            Door.SetTrigger("OpenTrigger");
            fenceCollider.isTrigger = true;
        }
    }

    // private void OnTriggerExit(Collider sluiten)
    // {
    //         Debug.Log("close");
            
    //         Door.SetTrigger("OpenTrigger");
    // }
}
