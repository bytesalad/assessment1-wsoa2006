using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralGameObject_Rotation : MonoBehaviour
{
    [SerializeField] private Gauge_Fill gaugeFillScript;

    [SerializeField] private float initialRotation;

    private float finalRotation;

    private void Start()
    {
        finalRotation = gameObject.transform.rotation.eulerAngles.z;
        //get the value of the rotation of the game object before this script changes it.
    }

    private void Update()
    {
        float difference = finalRotation - initialRotation;

        gameObject.transform.rotation = Quaternion.Euler(0, 0, gaugeFillScript.GetFillAmount() * difference);
    }
}
