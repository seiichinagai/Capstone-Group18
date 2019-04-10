using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPenguinShapeRoute : MonoBehaviour
{
   
   public penguinShapeAnimalRoute pShaped;
    private float distanceToPath = 1.0f;
    public float speedOfRot = 5.0f;
    public string pathName;
    
    public int ID = 0;
    public float objectSpeed;
    Vector3 last_position;
    Vector3 current_position;
    void Start()
    {
         // pShaped = GameObject.Find(pathName).GetComponent<penguinShapeAnimalRoute>();
        last_position = transform.position;
    }

   
    void Update()
    {
        float dis = Vector3.Distance(pShaped.routeTargets[ID].position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, pShaped.routeTargets[ID].position, Time.deltaTime * objectSpeed );

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
