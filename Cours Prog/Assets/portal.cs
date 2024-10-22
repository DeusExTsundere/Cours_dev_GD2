using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    [SerializeField] private GameObject portail;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        other.transform.position= portail.transform.position;
    }
}
