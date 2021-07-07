using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public Transform target;
    public Transform targetTwo;
    public GameObject patiska;
    public GameObject button;

    public Animator myAnimator;

    Button selection;

    void Start()
    {
        selection = button.GetComponent<Button>();
    }

    void Update()
    {
        if (selection.genisleme)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetTwo.position, Time.deltaTime * 1.2f);
            if (Vector3.Distance(transform.position, targetTwo.transform.position) < 0.1f && Vector3.Distance(transform.position, targetTwo.transform.position) > -0.1) myAnimator.SetInteger("walk", 3);
            else
                myAnimator.SetInteger("walk", 2);
            Debug.Log(1);

        }
        if (!selection.genisleme)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * 1.2f);
            if (Vector3.Distance(transform.position, target.transform.position) < 0.1f && Vector3.Distance(transform.position, target.transform.position) > -0.1f) myAnimator.SetInteger("walk", 3);
            else
                myAnimator.SetInteger("walk", 1);
            Debug.Log(2);
        }
    }
}
