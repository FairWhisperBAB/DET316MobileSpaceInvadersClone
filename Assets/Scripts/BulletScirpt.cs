using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScirpt : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("danger"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
