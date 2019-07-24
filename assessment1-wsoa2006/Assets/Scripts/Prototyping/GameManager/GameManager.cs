using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] gaugeChecks;

    [SerializeField] private GeneralGameObject_FollowPath playerFollowScript;

    [SerializeField] private string sceneToLoad;

    private void Update()
    {
        //check all the gaugeChecks booleans
        bool checkStates = true;

        for (int i = 0; i < gaugeChecks.Length; i++)
        {
            if (gaugeChecks[i].GetComponent<Interaction_Manager_GaugeLock>().GetLocked() == false)
            {
                checkStates = false;
            }
        }

        playerFollowScript.SetCanMove(checkStates);

        if (playerFollowScript.GetEndOfArrayFlag() == true)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
