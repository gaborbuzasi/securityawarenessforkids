using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public float speed = 1.0f;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ManageMove();
    }

    void ManageMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (!anim.GetBool("Walk"))
                anim.Play("Walk W Root");
            anim.SetBool("Walk", true);

            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            anim.SetBool("Walk", false);
        }
    }
}
