 using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 
 public class moveRandomly : MonoBehaviour {
     private float timeDirection;
     Rigidbody2D rigBody;
    public void Start () {
         changeRoute();
          rigBody = GetComponent<Rigidbody2D>();
        
     }
      public void Update () {
         timeDirection -= Time.deltaTime;
 
         if (timeDirection <= 0) {
             changeRoute();
         }
 
         rigidbody.velocity = transform.up * 2;
     }
    private void changeRoute() {
         float angle = Random.Range(0f, 360f);
         Quaternion quat = Quaternion.AngleAxis(angle, Vector3.forward);
         Vector3 newUp = quat * Vector3.up;
         newUp.z = 0;
         newUp.Normalize();
         transform.up = newUp;
         timeDirection = 1.5f;
     }
 }