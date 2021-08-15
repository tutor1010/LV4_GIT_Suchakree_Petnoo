using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMovement : MonoBehaviour
{
    private Vector3 offset;
    public GameObject ball;

    void Start()
    {
        offset = transform.position - ball.transform.position;
    }


    void Update()
    {
        transform.position = ball.transform.position + offset;
    }
}
