using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadScript : MonoBehaviour
{
    public GameObject player;
    public GameObject egga;
    public Transform respawnPlayer;
    public Transform respawnEgg;
    void OnTriggerEnter(Collider drown)
    {
        if(drown.gameObject.CompareTag("Player"))
        {
            Debug.Log("dead");
            player.transform.position = respawnPlayer.position;
        }
        else if(drown.gameObject.CompareTag("Egg"))
        {
            egga.transform.position = respawnEgg.position;
        }
    }
}
