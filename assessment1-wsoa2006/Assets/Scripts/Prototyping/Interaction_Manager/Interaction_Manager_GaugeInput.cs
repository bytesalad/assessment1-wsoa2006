using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction_Manager_GaugeInput : MonoBehaviour
{
    [SerializeField] private Button leftButton;

    [SerializeField] private Button rightButton;

    [SerializeField] private Gauge_Fill gaugeFillScript;

    [SerializeField] private float gaugeFillSpeed;

    public void Start()
    {
        leftButton.onClick.AddListener(LeftButtonClick);
        rightButton.onClick.AddListener(RightButtonClick);
    }

    private void LeftButtonClick()
    {
        float fillAmount = gaugeFillScript.GetFillAmount();

        if (fillAmount > 0f)
        {
            gaugeFillScript.SetFillAmount(fillAmount - gaugeFillSpeed);
        }
    }

    private void RightButtonClick()
    {
        float fillAmount = gaugeFillScript.GetFillAmount();

        if (fillAmount < 1f)
        {
            gaugeFillScript.SetFillAmount(fillAmount + gaugeFillSpeed);
        }
    }
}
