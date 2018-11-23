﻿ using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 
 public class moveRandomly : MonoBehaviour {
     private float timeToChangeDirection;
  Rigidbody2D rigidbody;
     // Use this for initialization
     public void Start () {
         ChangeDirection();
          rigidbody = GetComponent<Rigidbody2D>();
        
     }
     
     // Update is called once per frame
     public void Update () {
         timeToChangeDirection -= Time.deltaTime;
 
         if (timeToChangeDirection <= 0) {
             ChangeDirection();
         }
 
         rigidbody.velocity = transform.up * 2;
     }
 
 
 
     private void ChangeDirection() {
         float angle = Random.Range(0f, 360f);
         Quaternion quat = Quaternion.AngleAxis(angle, Vector3.forward);
         Vector3 newUp = quat * Vector3.up;
         newUp.z = 0;
         newUp.Normalize();
         transform.up = newUp;
         timeToChangeDirection = 1.5f;
     }
 }