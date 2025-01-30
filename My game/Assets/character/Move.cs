using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * 5 * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position += -transform.right * 5 * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position += -transform.forward * 5 * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 5 * Time.deltaTime;
            animator.SetFloat("speed", 1);
        }
        else
        {
            animator.SetFloat("speed", 0);

        }


        float mouseXmove = Input.GetAxis("Mouse X");
        Debug.Log(mouseXmove);
        transform.Rotate(0, mouseXmove, 0);
    }
}
