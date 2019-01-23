using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;



    public class cameraSwitch : MonoBehaviour
    {

        float currentTime = 0f;
        float startTime = 1f;
        public bool SwitchCamera = false;
        public Camera secondCamera;
        public KeyCode pressedKey;
        System.Timers.Timer time;

     void Start()
    {
        currentTime = startTime;
    }
    void Update()
        {
       
        currentTime += 1 * Time.deltaTime;
        
        Debug.Log((int) currentTime );

        if ((int)currentTime == 27){
            Camera.main.enabled = false;
            SwitchCamera = !SwitchCamera;
            secondCamera.gameObject.SetActive(SwitchCamera);
            
        }
        }
    
       
       
        
        
    

  
 



}

    