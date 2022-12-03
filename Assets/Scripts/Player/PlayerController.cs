using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool isAlive = true;
    [SerializeField] float torqueAmount = 3f;
    [SerializeField] float speed = 15;
    Rigidbody2D playerRigidBody2d;
    SurfaceEffector2D surfaceEffector2D;
    private void Awake()
    {
        playerRigidBody2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        isAlive = true;
    }

    void Update()
    {
        if (isAlive)
        {
            RotatePlayer();
            RespondToBoos();
        }
    }

    void RespondToBoos()
    {
        if (Input.GetKey(KeyCode.W))
        {
            surfaceEffector2D.speed = speed + 20;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            surfaceEffector2D.speed = speed - 10;
        }
        else
        {
            surfaceEffector2D.speed = speed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerRigidBody2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerRigidBody2d.AddTorque(-torqueAmount);
        }
    }
}
