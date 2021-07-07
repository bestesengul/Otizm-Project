using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genisle : MonoBehaviour
{
    public Transform one;
    public Transform two;

    float scaleOne;
    float scaleTwo;
    float dif;
    float difTwo;

    void Start()
    {
        dif = Vector3.Distance(one.position, two.position);
        scaleOne = this.gameObject.transform.localScale.x;
    }

    void Update()
    {
        difTwo = Vector3.Distance(one.position, two.position);
        scaleTwo = (scaleOne * difTwo / dif);
        this.gameObject.transform.localScale = new Vector3(1.1f * scaleTwo, this.gameObject.transform.localScale.y, this.gameObject.transform.localScale.z);
    }
}
