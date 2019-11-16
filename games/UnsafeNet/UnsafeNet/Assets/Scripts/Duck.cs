using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpHeight = 1.0f;
    public float turnSpeed = 100.0f;

    private Animator anim;
    private Rigidbody rbody;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (!anim.GetBool("Walk"))
                anim.Play("Walk In Place");
            anim.SetBool("Walk", true);

            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (!anim.GetBool("Walk"))
                anim.Play("Walk In Place");
            anim.SetBool("Walk", true);

            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        else
        {
            anim.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime, Space.Self);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime, Space.Self);

        if (Input.GetKey(KeyCode.Space))
            anim.Play("Jump W Root");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Eat!");
            anim.SetTrigger("Interact");
        }
    }
}
