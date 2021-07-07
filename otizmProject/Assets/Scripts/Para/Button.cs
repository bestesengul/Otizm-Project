using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    int sayac = 1;

    public GameObject Tepsi;
    public GameObject Patiska;
    public bool genisleme = false;
    public Text secimButonu;

    public GameObject para;

    public GameObject paraButonu;

    GameObject clone;
    public void secim()
    {
        sayac++;
        if (sayac == 1)
        {
            StartCoroutine(yarat());
            Patiska.SetActive(false);
            secimButonu.text = "Patiska";
            genisleme = false;
        }
        if (sayac == 2)
        {
            Patiska.SetActive(true);
            Tepsi.SetActive(false);
            secimButonu.text = "Tepsi";
            genisleme = true;
            sayac = 0;
        }
        IEnumerator yarat()
        {
            yield return new WaitForSeconds(0.75f);
            Tepsi.SetActive(true);
        }
    }

    public void button()
    {
        if (clone != null) Destroy(clone);
        yarat();

    }

    private void yarat()
    {
        Vector3 pos = new Vector3(Random.Range(-0.5f,0.5f), Random.Range(1.75f, 2.25f), Random.Range(-5.55f,-5.95f));
        //peçete yarat
        clone = Instantiate(para, pos, Quaternion.Euler(90, 0, 0));
    }
}
