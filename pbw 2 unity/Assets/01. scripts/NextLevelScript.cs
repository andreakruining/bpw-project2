using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider levelUpgrade)
    {
        if(levelUpgrade.GetComponent<Collider>().tag == "Player")
        {
            Debug.Log("nextlevel");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
