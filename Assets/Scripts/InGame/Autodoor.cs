using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodoor : MonoBehaviour
{
    public Animator doorAnim;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorAnim.SetTrigger("open");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorAnim.SetTrigger("close");
        }
    }
}
