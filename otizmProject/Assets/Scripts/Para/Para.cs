using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Para : MonoBehaviour
{
    public bool peceteVar = false;
    public bool carpti = false;
    public int sekmeSayisi;
    private Rigidbody paraRB;

    public Material coin;
    public Material pecete;

    void Start()
    {
        paraRB = GetComponent<Rigidbody>();
        sekmeSayisi = 1;
        GetComponent<MeshRenderer>().material = coin;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            peceteVar = true;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            paraRB.isKinematic = false;
        }
        if (carpti == true)
        {
            transform.Rotate((200 * sekmeSayisi) * Time.deltaTime, 0, 0);
        }
        if (sekmeSayisi >= 3)
        {
            carpti = false;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (peceteVar)
        {
            GetComponent<MeshRenderer>().material = pecete;
        }
        if (!peceteVar)
        {
            GetComponent<MeshRenderer>().material = coin;
        }
    }
}
