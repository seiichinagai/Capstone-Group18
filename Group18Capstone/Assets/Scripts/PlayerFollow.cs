using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public Transform player;
    private Vector3 camOff;
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    public bool LookAtPlayer = false;

	
	void Start () {
        camOff = transform.position - player.position;	
	}
	
	
	void Update () {
        Vector3 newPos = player.position + camOff;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer)
            transform.LookAt(player);
    }
}