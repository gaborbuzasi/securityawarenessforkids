using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpHeight = 1.0f;
    public float turnSpeed = 100.0f;
    public InteractController ictrl;

    public int keyCount = 0;
    public int health = 3;

    private Animator anim;
    private Rigidbody rbody;
    private bool open;
    private Interactable currentTile;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
        open = false;
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

        if (Input.GetKeyDown(KeyCode.Space))
            anim.Play("Jump W Root");

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("Interact");

            if (!open)
            {
                if (currentTile && currentTile.type != InteractType.Bridge && !currentTile.finished)
                    ictrl.Handle(currentTile);
                open = true;
            }
            else
            {
                ictrl.Close();
                open = false;
            }
        }

    }

    public void Open()
    {
        open = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Interactable tile = collision.collider.GetComponent<Interactable>();
        if (tile)
            currentTile = tile;
    }
}
