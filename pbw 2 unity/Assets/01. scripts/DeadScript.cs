using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadScript : MonoBehaviour
{

        void OnTriggerEnter(Collider drown)
        {
            if(drown.GetComponent<Collider>().tag == "Water")
            {
                Debug.Log("dead");
            }
        }
}
