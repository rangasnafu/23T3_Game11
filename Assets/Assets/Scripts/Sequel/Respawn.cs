using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject player;

    private Vector3 respawnPosition = new Vector3(0f, 2.89f, 0f);

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPosition;
        }
    }
}
