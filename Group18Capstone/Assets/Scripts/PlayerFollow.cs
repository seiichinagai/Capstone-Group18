using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    private Vector3 bedroomView;
    Camera mainCam;
    public Transform player;
    private Vector3 camOff;
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    public bool LookAtPlayer = false;
    public bool zoom = false;
    float currentTime = 0f;
    float startTime = 1f;
    float xx;

    void Start () {
        camOff = new Vector3(0f, 15f, 80f);
        currentTime = startTime;
       // camOff = transform.position - player.position;	
	}
	
	
	void Update () {

     
        
        currentTime += 1 * Time.deltaTime;
        if ((int)currentTime == 30 )
        {
           Camera.main.transform.position = new Vector3(210f, 20f, 80f); ;
           //Camera.current.transform.rotation = Quaternion.Euler(30, 30, 0);
        }

        if ((int)currentTime == 27 || (int)currentTime >= 27)
        {
            Vector3 newPos = player.position + camOff;
            transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
           
            if (LookAtPlayer)
            transform.LookAt(player);
}
    }
           
        
       
}