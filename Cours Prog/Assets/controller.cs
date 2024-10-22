using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class controller : MonoBehaviour
{
    [SerializeField]private float speed = 0.0001f;
    private bool forward = false;
    private bool backward = false;
    private bool right = false;
    private bool left = false;
    private Vector2 rotate;
    private Vector3 rotation;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        rotation.y += rotate.x;
        if (forward)
        {
            transform.position += transform.forward * speed;
        }

        if (backward)
        {
            transform.position += transform.forward * -speed;
        }

        if (right)
        {
            transform.position += transform.right * speed;
        }

        if (left)
        {
            transform.position += transform.right * -speed;
        }
        transform.rotation = Quaternion.Euler(rotation);
        }

    public void MoveForward(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            forward = true;
        }
        else if (context.canceled)
        {
            forward = false;
        }
    }

    public void MoveBack (InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            backward = true;
        }
        else if (context.canceled)
        {
            backward = false;
        }
    }

    public void MoveRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            right = true;
        }
        else if (context.canceled)
        {
            right = false;
        }
    }

    public void MoveLeft (InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            left = true;
        }
        else if (context.canceled)
        {
            left = false;
        }
    }

    public void CameraRotate(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rotate=context.ReadValue<Vector2>();
        }
        else
        {
            rotate=Vector2.zero;
        }
    }
}
