using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public Duck duck;
    public InteractController ictrl;
    public int minKeys = 3;

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (duck.keyCount < 3)
        {
            ictrl.Handle($"You need at least {minKeys} keys to pass!");
            duck.transform.position -= duck.transform.forward * 0.2f;
            duck.Open();
        }
        else
        {
            ictrl.Handle(GetComponent<Interactable>());
        }
    }
}
