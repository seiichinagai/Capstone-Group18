using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    private Vector3 bedroomView;
    Camera mainCam;
    public Transform player;
    public Transform player2;
    private Vector3 camOff;
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    public bool LookAtPlayer = false;
    public bool zoom = false;
    float currentTime = 0f;
    float startTime = 1f;
    public readonly float _TIME = 27;
    public readonly float _TIME2 = 47;
    void Start () {
        camOff = new Vector3(0f, 5f, 40f);
        currentTime = startTime;
       // camOff = transform.position - player.position;	
	}
	
	
	void Update () {

     
        
        currentTime += 1 * Time.deltaTime;
        
        if ((int)currentTime == 28)
        {
            Camera.main.transform.position = new Vector3(210f, 20f, 80f); 
            //Camera.current.transform.rotation = Quaternion.Euler(30, 30, 0);
        }
       

       // if ((int)currentTime >= _TIME  && !((int)currentTime > _TIME2))
        if ((int)currentTime >= _TIME  )
            {
            Vector3 newPos = player.position + camOff;
            transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
           
            if (LookAtPlayer)
            transform.LookAt(player);
        }

        /*
        if ((int)currentTime > _TIME2)
        {
            Vector3 newPos = player2.position + camOff;
            transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

            if (LookAtPlayer)
                transform.LookAt(player2);

            if ((int)currentTime == 67) 
                currentTime = 29;
        }
        */

    }
           
        
       
}