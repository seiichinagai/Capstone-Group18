using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.AI;
 public class moveRandomly : MonoBehaviour
{
    public float timer;
    public int changeDirection;
    public float velocity;
    public NavMeshAgent agent;
    public Vector3 vec;

 void Start ()
 {
     agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent> ();
 }
 
 void Update () 
 {
     timer += Time.deltaTime;
     if (timer >= changeDirection)
     {
         getTarget();
         timer = 0;
         agent.speed = velocity;
     }
 }
 void getTarget()
 {
     float newX = gameObject.transform.position.x;
     float newZ = gameObject.transform.position.z;
     float positionX = newX + Random.Range (newX - 100, newX + 100);
     float positionZ = newZ + Random.Range (newZ - 100, newZ + 100);
     vec = new Vector3 (positionX, gameObject.transform.position.y, positionZ);
     agent.SetDestination (vec);
 }
}