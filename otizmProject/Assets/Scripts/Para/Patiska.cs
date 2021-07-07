using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patiska : MonoBehaviour
{
    private bool peceteVar;
    private Rigidbody paraRB;
    public GameObject paraButonu;
    private int sekmeSayisi;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Para"))
        {
            peceteVar = collision.gameObject.GetComponent<Para>().peceteVar;
            paraRB = collision.gameObject.GetComponent<Rigidbody>();
            sekmeSayisi = collision.gameObject.GetComponent<Para>().sekmeSayisi;

            if (peceteVar == false)
            {
                paraRB.AddForce(0, 200 / sekmeSayisi, 0);
                collision.gameObject.GetComponent<Para>().sekmeSayisi++;
                collision.gameObject.GetComponent<Para>().carpti = true;
                StartCoroutine(ButonAc());
            }
            if (peceteVar == true && sekmeSayisi < 2)
            {
                paraRB.AddForce(0, 100, 0);
                collision.gameObject.GetComponent<Para>().sekmeSayisi++;
                StartCoroutine(ButonAc());
            }

        }
        IEnumerator ButonAc()
        {
            yield return new WaitForSeconds(1.2f);
            paraButonu.SetActive(true);
        }
    }

}
