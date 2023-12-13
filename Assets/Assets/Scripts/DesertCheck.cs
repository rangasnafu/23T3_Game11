using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesertCheck : MonoBehaviour
{
    public Slider slider;

    public int maxPercent = 10;
    public int percent;

    // Start is called before the first frame update
    void Start()
    {
        percent = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetMaxPercent(int percent)
    {
        slider.value = percent;
        slider.maxValue = maxPercent;
    }

    public void GainPercent(int percent)
    {
        slider.value += 1f;
        //percent += 1;
        //slider.value = percent;

    }

    public void LosePercent(int percent)
    {
        slider.value -= 1f;
        //percent += 1;
        //slider.value = percent;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Desert")
        {
            //slider.value = 0.1f;
            GainPercent(1);
            Debug.Log("desert item in desert dome");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Desert")
        {
            //slider.value = 0.1f;
            LosePercent(1);
            Debug.Log("desert item out of desert dome");
        }

    }
}
