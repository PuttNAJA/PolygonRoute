using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0.25f, -0.4f, 0.25f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScoreManager.scoreCount += 1;
        }
    }
}
