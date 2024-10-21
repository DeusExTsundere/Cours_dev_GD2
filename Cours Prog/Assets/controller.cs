using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class controller : MonoBehaviour
{
    private float speed = 0.0001f;
    public void MoveForward(InputAction.CallbackContext context)
    {
        transform.position += Vector3.forward * speed;
    }

    public void MoveBack (InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.position += Vector3.back * speed;
        }
    }

    public void MoveRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.position += Vector3.right *speed;
        }
    }

    public void MoveLeft (InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.position += Vector3.left *speed;
        }
    }
}
