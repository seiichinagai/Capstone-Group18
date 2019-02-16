using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{

    private Vector3 bedroomView;
    Camera mainCam;
    public Transform player;
    private Vector3 camOff;
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    public bool LookAtPlayer = false;
    float currentTime = 0f;
    float startTime = 1f;
    float xx;

    void Start()
    {
        //bedroomView = new Vector3(210f, 20f, 80f);

        currentTime = startTime;
        camOff = transform.position - player.position;
    }


    void Update()
    {

        currentTime += 1 * Time.deltaTime;
        if ((int)currentTime == 30)
        {

            Camera.main.transform.position = new Vector3(210f, 20f, 80f); ;
            //Camera.main.transform.rotation = Quaternion.Euler(30, 30, 0);
            // mainCam.fieldOfView = 13;
        }

        if ((int)currentTime == 27 || (int)currentTime >= 27)
        {

            Vector3 newPos = player.position + camOff;
            transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

            if (LookAtPlayer)
                transform.LookAt(player);
        }
    }

    /*
     * Script modifications and testing
     */
    /*
    public GameObject player;       //Public variable to store a reference to the player game object

    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    float currentTime = 1f;

    // Use this for initialization
    void Start()
    {
        currentTime = 1f;
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        currentTime += 1 * Time.deltaTime;
        if ((int)currentTime >= 27)
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            transform.position = player.transform.position + offset;
    }
    */

}