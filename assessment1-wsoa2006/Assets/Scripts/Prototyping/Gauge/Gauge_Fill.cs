using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge_Fill : MonoBehaviour
{
    [SerializeField] Image gaugeImage;

    private float fillAmount;
    //a number between 0 and 1 that tells the program how much the image should be filled

    public void SetFillAmount(float fillAmount_)
    {
        fillAmount = fillAmount_;
    }

    public float GetFillAmount()
    {
        return fillAmount;
    }

    private void Update()
        //runs once a frame hopefully this does not cause laggy issues.
    {
        gaugeImage.fillAmount = fillAmount;
    }
}
