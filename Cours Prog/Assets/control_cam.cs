using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class control_cam : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector2 rotate;
    private Vector3 rotation;

    private void Update()
    {
        transform.LookAt(player.transform);
    }

    public void CameraRotate(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rotate = context.ReadValue<Vector2>();
        }
        else
        {
            rotate = Vector2.zero;
        }
    }
}
