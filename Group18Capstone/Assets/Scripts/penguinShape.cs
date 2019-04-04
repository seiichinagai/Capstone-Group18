using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class penguinShape : MonoBehaviour
{
    public Color whiteColor = Color.white;
    public List<Transform> routeTargets = new List<Transform>();
    Transform [] destinations;
   
     void OnDrawGizmos()
    {

        Gizmos.color = whiteColor;
        destinations = GetComponentsInChildren <Transform>();
        routeTargets.Clear();
        foreach (Transform des in destinations) {

            if (des != this.transform) {
                routeTargets.Add(des);
            }

        }

        for (int i = 0; i < routeTargets.Count; i++) {

            Vector3 newPos = routeTargets[i]. position;

            if (i > 0) {

                Vector3 previous = routeTargets[i - 1].position;
                Gizmos.DrawLine(previous, newPos);
                Gizmos.DrawWireSphere(newPos, 0.3f);

            }
        }

    }
}
