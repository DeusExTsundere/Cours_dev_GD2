using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shoot_portal : MonoBehaviour
{
    [SerializeField] private GameObject portail_1;
    [SerializeField] private GameObject portail_2;
    RaycastHit hit;
    private Direction currentDirection = Direction.none;
    private Vector3 newPosition;
    private Vector3 newRotation;

    private void Start()
    {
        Debug.DrawLine(transform.position, transform.forward * Mathf.Infinity, Color.red);
    }

    //private void Update()
    //{
    //    newRotation = transform.rotation.eulerAngles;
    //    if (newRotation.y < 45 && newRotation.y > 115)
    //    {
    //        currentDirection = Direction.front;
    //    }
    //    else if (newRotation.y > 115 && newRotation.y < 205)
    //    {
    //        currentDirection = Direction.right;
    //    }
    //    else if (newRotation.y >295 &&  newRotation.y < 355)
    //    {
    //        currentDirection = Direction.back;
    //    }
    //    else
    //    {
    //        currentDirection=Direction.left;
    //    }
    //}

    public void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            Debug.Log(hit.point);
            Debug.Log(-hit.point);  
        }
    }

    public void Shoot_Portal_1(InputAction.CallbackContext context)
    {
        newPosition = hit.point;
        newPosition.y += 0.5f;
        if (context.started)
        {
            portail_1.transform.position = newPosition;
            portail_1.transform.LookAt(new Vector3(hit.point.x,-hit.point.y,-hit.point.z));
        }
        //portail_1.transform.position = Vector3.MoveTowards(transform.position, new Vector3(-hit.point.x, hit.point.y, -hit.point.z),0.0005f);
    }

    public void Shoot_Portal_2(InputAction.CallbackContext context)
    {
        newPosition = hit.point;
        newPosition.y += 0.5f;
        if (context.started)
        {
            portail_2.transform.position = newPosition;
            portail_2.transform.LookAt(new Vector3(hit.point.x, -hit.point.y,-hit.point.z));
            //portail_2.transform.position = Vector3.MoveTowards(transform.position, new Vector3(-hit.point.x, hit.point.y, -hit.point.z), 0.0005f);
        }
    }
}

enum Direction
{
    front,
    back, 
    right,
    left,
    none

}
