using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPenguinShapeRoute : MonoBehaviour
{

    Vector3 last_position;
    Vector3 current_position;
    private float distanceToPath = 1.0f;
    public float speedOfRot = 5.0f;
    public string pathName;
    public penguinShape pShaped;
    public int ID = 0;
    public float objectSpeed;
   
    void Start()
    {
      
        last_position = transform.position;
    }

   
    void Update()
    {
        float dis = Vector3.Distance(pShaped.routeTargets[ID].position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, ps.routeTargets[ID].position, Time.deltaTime * objectSpeed );

        var rotation = Quaternion.LookRotation(pShaped.routeTargets[ID].position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speedOfRot);

        if (dis <= distanceToPath) {
            ID++;
        }
        if (ID >= pShaped.routeTargets.Count) {
            ID = 0; 
        }
    }
}
