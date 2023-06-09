using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRASHSCRIPT_BPW2 : MonoBehaviour
{
    //script for all the deleted/commented logic so the scripts look clean
    //and I won't lose all the logic I could use for something else

    //DoorController script to open a door with animation on trigger
    // [SerializeField] private bool openTrigger = false;
    // [SerializeField] private bool closeTrigger = false;
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

    //JumpMove script to play sound on trigger
    //private float delay = 2.5f;

    //public AudioSource audioSource;

    //private void OnTriggerEnter(Collider springen)
    //{

    //    if(springen.CompareTag("Egg"))
    //    {
    //        audioSource.Play();
    //        StartCoroutine(TriggeredEvent());
    //    }
    //}

    //private IEnumerator TriggeredEvent()
    //{
    //    Debug.Log("event started");

    //    JumpForce = 10f;
    //    yield return new WaitForSeconds(delay);

    //    Debug.Log("event ended");
    //    JumpForce = 5f;
    //}

     //if(Input.GetKey("space"))
     //{
     //     rb_P.velocity = transform.up* JumpForce;
     //}
     //transform.position = position;

//PlayerLook script in which in the player looks at the mouse
//worldMousePosition.y = 0;
//transform.rotation = Quaternion.LookRotation(worldMousePosition - transform.position);





void Start()
    {
        
    }

    void Update()
    {
        
    }
}
