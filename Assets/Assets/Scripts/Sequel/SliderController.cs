using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SliderController : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;

    //public int maxValue = 10;

    public GameObject winUI;

    // Update is called once per frame
    void Update()
    {
        // Check if all sliders are at their max value
        if (slider1.value == slider1.maxValue &&
            slider2.value == slider2.maxValue &&
            slider3.value == slider3.maxValue)
        {
            // Activate the UI element
            winUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            // Deactivate the UI element
            winUI.SetActive(false);
        }


        if (winUI.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SequelScene");
        }
    }
}
