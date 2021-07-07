using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tepsi : MonoBehaviour
{
    private bool peceteVar;
    private Rigidbody coinRB;
    private int sekmeSayisi;
    public GameObject coinButton;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Para"))
        {
            peceteVar = collision.gameObject.GetComponent<Para>().peceteVar;
            coinRB = collision.gameObject.GetComponent<Rigidbody>();
            sekmeSayisi = collision.gameObject.GetComponent<Para>().sekmeSayisi;

            if (peceteVar == false)
            {

                coinRB.AddForce(0, 500 / (sekmeSayisi + 1), 0);
                //Ses çalacak
                collision.gameObject.GetComponent<Para>().sekmeSayisi++;
                collision.gameObject.GetComponent<Para>().carpti = true;
                StartCoroutine(ButonAc());
            }
            if (peceteVar == true && sekmeSayisi < 2)
            {
                //ses çalmayacak
                coinRB.AddForce(0, 100, 0);
                collision.gameObject.GetComponent<Para>().sekmeSayisi++;
                StartCoroutine(ButonAc());
            }

        }
        IEnumerator ButonAc()
        {
            yield return new WaitForSeconds(1.2f);
            coinButton.SetActive(true);
        }
    }

}
