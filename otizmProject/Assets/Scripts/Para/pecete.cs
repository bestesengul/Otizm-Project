using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pecete : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Para")
        {
            other.GetComponent<Para>().peceteVar = true;
        }
    }
}
