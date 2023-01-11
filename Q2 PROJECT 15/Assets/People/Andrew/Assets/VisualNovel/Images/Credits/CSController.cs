using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSController : MonoBehaviour
{
    //Don’t forget using UnityEngine.UI;
    public Slider slider;
    public float sliderVal;
    public GameObject p1, p2;


    // Update is called once per frame
    void Update()
    {

        sliderVal = slider.value;
        //More efficient is to only move player when slider CHANGES

        Vector3 playerPos = Vector3.Lerp(p1.transform.position, p2.transform.position, sliderVal);
        this.transform.position = playerPos;

    }

}
