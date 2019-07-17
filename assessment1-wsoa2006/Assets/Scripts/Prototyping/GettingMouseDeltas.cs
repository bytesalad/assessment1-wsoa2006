using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingMouseDeltas : MonoBehaviour
{
    private bool firstStroke = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePosition_A = Camera.main.ScreenToWorldPoint(Input.mouseScrollDelta);

        }
    }
}
