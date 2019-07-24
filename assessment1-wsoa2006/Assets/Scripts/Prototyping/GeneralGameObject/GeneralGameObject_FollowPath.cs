using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralGameObject_FollowPath : MonoBehaviour
{
    [SerializeField] private Transform[] pathPoints;
    //a collection of points that the object will use as nodes to move linearly between. More points can more accurately define curves.

    [SerializeField] private float speed;
    //the rate at which the object traverses between the points

    private int waypointCount = 0;
    //counts the points that the object must move in between

    private void Update()
    {
        if (waypointCount <= (pathPoints.Length - 1))
        //if there are points to move to
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, pathPoints[waypointCount].position, speed * Time.deltaTime);
            //go to the next point

            if (gameObject.transform.position == pathPoints[waypointCount].position)
            //if the next point is reached
            {
                waypointCount++;
            }
        }
    }
}
