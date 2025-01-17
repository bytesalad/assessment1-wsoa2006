﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction_Manager_GaugeLock : MonoBehaviour
{
    [SerializeField] private float gaugeAmountLock;
    //this value has to be within the gaugeFillSpeed of the Interaction_Manager_GaugeInput script located on the
    //same game object.

    public float GetGaugeLock()
    {
        return gaugeAmountLock;
    }

    private Gauge_Fill gaugeFillScript;

    private void Start()
    {
        gaugeFillScript = gameObject.GetComponent<Gauge_Fill>();
    }

    private void Update()
    {
        //mathf.approximately is used because the float values tend to differ slightly for some reason.
        if (Mathf.Approximately(gaugeFillScript.GetFillAmount(), gaugeAmountLock))
        {
            Debug.Log("Correct value");
        }
    }
}
