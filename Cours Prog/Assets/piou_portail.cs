using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class piou_portail : MonoBehaviour
{
    [SerializeField] private GameObject projectil1;
    [SerializeField] private GameObject projectil2;

    public void tire1(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Instantiate(projectil1);
        }
    }
    public void tire2(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Instantiate(projectil2);
        }
    }
}
