using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
