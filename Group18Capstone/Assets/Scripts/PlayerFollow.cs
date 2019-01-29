using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public Transform player;
    private Vector3 camOff;
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    public bool LookAtPlayer = false;

    float currentTime = 0f;
    float startTime = 1f;

    void Start () {
        currentTime = startTime;
        camOff = transform.position - player.position;	
	}
	
	
	void Update () {
        currentTime += 1 * Time.deltaTime;
       if ((int)currentTime == 27 || (int)currentTime >= 27)
        {
             Vector3 newPos = player.position + camOff;
            transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
        if (LookAtPlayer)
            transform.LookAt(player);
        }
    }
           
        
       
}