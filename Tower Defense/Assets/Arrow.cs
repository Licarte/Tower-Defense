using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject waypoint;
    public Transform arrow;
    public float speed;
    void Start()
    {

    }

    void Update()
    {
        Vector3 newPosition = arrow.position;
        newPosition.x += Time.deltaTime * speed;
        arrow.position = newPosition;
    }
}
