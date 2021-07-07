using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kavanoz : MonoBehaviour
{
    bool rotate = false;
    public Transform tencere;
    Animator animator;

    bool isBack = false;

    Transform myTransform;

    private void Start()
    {
        animator = GetComponent<Animator>();
        myTransform = transform;
    }
    private void Update()
    {
        if (rotate && !isBack)
        {

            transform.position = Vector3.MoveTowards(transform.position, tencere.transform.position, Time.deltaTime);
            animator.SetBool("open", true);

            if (transform.position == tencere.transform.position)
            {
                if (transform.rotation.x * 180 > -55)
                    transform.Rotate(Vector3.left, 20 * Time.deltaTime, Space.World);//çizilen vektöre yönel
            }
        }

        if (isBack)
        {
            MoveBack();
        }
    }
    private void OnMouseDown()
    {

    }

    private void OnMouseUp()
    {
        rotate = true;
        StartCoroutine(WaitTime(7f));
    }

    IEnumerator WaitTime(float wait)
    {
        yield return new WaitForSeconds(wait);
        isBack = true;
    }

    private void MoveBack()
    {
        if (transform.rotation.x * 180 < 0)
            transform.Rotate(Vector3.right, 20 * Time.deltaTime, Space.World);
        transform.position = Vector3.MoveTowards(transform.position, myTransform.position, Time.deltaTime * 5);
    }
}
