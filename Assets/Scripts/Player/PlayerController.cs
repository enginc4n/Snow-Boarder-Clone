using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool isAlive = true;
    [SerializeField] float torqueAmount = 3f;
    Rigidbody2D playerRigidBody2d;
    private void Awake()
    {
        playerRigidBody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
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
