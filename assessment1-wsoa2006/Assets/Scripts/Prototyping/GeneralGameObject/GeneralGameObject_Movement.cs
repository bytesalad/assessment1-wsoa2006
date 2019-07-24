using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralGameObject_Movement : MonoBehaviour
{
    [SerializeField] private Vector2 initialPosition;

    [SerializeField] private Gauge_Fill gaugeFillScript;

    [SerializeField] private Interaction_Manager_GaugeLock gaugeLockScript;

    private Vector2 finalPosition;

    private void Start()
    {
        finalPosition = gameObject.transform.position;
    }

    private void Update()
    {
        Vector2 resultant = finalPosition - initialPosition;

        gameObject.transform.position = resultant * (gaugeFillScript.GetFillAmount() / gaugeLockScript.GetGaugeLock());
    }
}
