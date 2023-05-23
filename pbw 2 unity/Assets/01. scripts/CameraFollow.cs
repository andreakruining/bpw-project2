using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //[SerializeField]
    //public GameObject player;

    //[SerializeField]
    //float timeOffset;

    //[SerializeField]
    //Vector3 posOffset;

    //[SerializeField]
    //float leftLimit;
    //[SerializeField]
    //float rightLimit;
    //[SerializeField]
    //float bottomLimit;
    //[SerializeField]
    //float topLimit;

    //private Vector3 veloc;

    //private void Update()
    //{
    //    //cameras current position
    //    Vector3 startPos = transform.position;
    //    //players current position
    //    Vector3 endPos = player.transform.position;

    //    endPos.x += posOffset.x;
    //    endPos.y += posOffset.y;
    //    endPos.z = -10;

    //    //smoothly move camera towards player pos
    //    transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);

    //    transform.position = new Vector3(
    //        Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
    //        Mathf.Clamp(transform.position.y, bottomLimit, topLimit),
    //        transform.position.z);
    //}
    public Transform player;
    public Vector3 offset;

    //// Update is called once per frame

    //private void Start()
    //{
    //    offset = transform.position = new Vector3(
    //        Mathf.Clamp(player.position.x, 1.077981f, 1.22f),
    //        Mathf.Clamp(player.position.y, 0.5530509f, 0.56f),
    //        transform.position.z);

    //    transform.position = offset;
    //}
    void Update()
    {
        transform.position = player.position + offset;

    }
}