using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portail : MonoBehaviour
{
    [SerializeField] private GameObject autrePortail;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = autrePortail.transform.position;
            other.transform .LookAt(-autrePortail.transform.position);
        }
    }
}
