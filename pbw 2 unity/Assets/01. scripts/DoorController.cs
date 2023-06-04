using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator Door = null;

    public GameObject fence;


    // [SerializeField] private bool openTrigger = false;
    // [SerializeField] private bool closeTrigger = false;

    void Start()
    {
        Door = fence.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        inPlace();
    }

    public void inPlace()
    {
        

        if (transform.position == new Vector3(3f, 1.5f, 2f))   //openen.GetComponent<Collider>().tag == "EndTrigger" )
        {
            Collider fenceCollider = fence.GetComponent<Collider>();
            Debug.Log("open");
            //Door.SetBool("TriggerBool", true);
            Door.SetTrigger("OpenTrigger");
            fenceCollider.isTrigger = true;
        }
    }

    //private void OnTriggerEnter(Collider openen)
    //{
    //    Collider fenceCollider = fence.GetComponent<Collider>();

    //    if (transform.position == new Vector3(3f, 1.5f, 2f))   //openen.GetComponent<Collider>().tag == "EndTrigger" )
    //    {
    //        Debug.Log("open");
    //        //Door.SetBool("TriggerBool", true);
    //        Door.SetTrigger("OpenTrigger");
    //        fenceCollider.isTrigger = true;
    //    }
    //}

    // private void OnTriggerExit(Collider sluiten)
    // {
    //         Debug.Log("close");
            
    //         Door.SetTrigger("OpenTrigger");
    // }
}
