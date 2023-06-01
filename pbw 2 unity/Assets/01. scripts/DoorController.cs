using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator Door;

    public GameObject fence;


    // [SerializeField] private bool openTrigger = false;
    // [SerializeField] private bool closeTrigger = false;

    void Start()
    {
        Door = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider openen)
    {
        Collider fenceCollider = fence.GetComponent<Collider>();

        if(openen.CompareTag("EndTrigger"))
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
