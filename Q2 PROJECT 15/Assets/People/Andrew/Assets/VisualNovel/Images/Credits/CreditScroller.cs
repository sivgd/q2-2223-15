using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditScroller : MonoBehaviour
{
    //Don’t forget include UnityEngine.UI;
    public Slider slider;
    public float maxTime;
    public float elapsedTime;


    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        slider.value = elapsedTime / maxTime;
        if (elapsedTime > maxTime)
        {
            elapsedTime = 0;

        }
    }

}
