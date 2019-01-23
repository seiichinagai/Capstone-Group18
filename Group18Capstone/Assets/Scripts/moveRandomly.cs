using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.AI;
 public class moveRandomly : MonoBehaviour
{

    float currentTime = 0f;
    float startTime = 1f;
    public float timer;
    public int changeDirection;
    public float velocity;
    public NavMeshAgent agent;
    public Vector3 vec;
 

    void Start ()
 {
       
        currentTime = startTime;
        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent> ();
 }
 
 void Update () 
 {
        currentTime += 1 * Time.deltaTime;
        timer += Time.deltaTime;
        
        if (timer >= changeDirection ){
            if ((int)currentTime == 27 ||(int)currentTime  >= 27){
                getTarget();
            }
               timer = 0;
               agent.speed = velocity;
            }
        
 }
 public void getTarget()
 {
            float newX = gameObject.transform.position.x;
            float newZ = gameObject.transform.position.z;
            float positionX = newX + Random.Range(newX - 200, newX + 200);
            float positionZ = newZ + Random.Range(newZ - 200, newZ + 200);
            vec = new Vector3(positionX, gameObject.transform.position.y, positionZ);
            agent.SetDestination(vec);
        
 }

   
}