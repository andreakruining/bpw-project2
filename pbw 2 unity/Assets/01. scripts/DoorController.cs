using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator Door = null;

    public GameObject fence;

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
        

        if (transform.position == new Vector3(3f, -3.81f, 2f))
        {
            Collider fenceCollider = fence.GetComponent<Collider>();
            Debug.Log("open");
            Door.SetTrigger("OpenTrigger");
            fenceCollider.isTrigger = true;
        }
    }
}
