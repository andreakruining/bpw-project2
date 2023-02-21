using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateChicken : MonoBehaviour
{
    JumpMove jumpMove;

    public float Speed= 5f;
    public float TurnSpeed = 90f;

    // Start is called before the first frame update
    void Awake()
    {
        jumpMove = GetComponent<JumpMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
