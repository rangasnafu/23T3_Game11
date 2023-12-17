using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquaticDeath : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gameOverUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
