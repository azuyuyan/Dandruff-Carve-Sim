using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KepekControll : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tarak"))
        {
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
