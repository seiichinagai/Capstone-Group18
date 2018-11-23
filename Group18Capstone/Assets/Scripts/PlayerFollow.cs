using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public Transform Player;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;

	// Use this for initialization
	void Start () {
        _cameraOffset = transform.position - Player.position;	
	}
	
	// LateUpdate is called after Update
	void Update () {
        Vector3 newPos = Player.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer)
            transform.LookAt(Player);

	}
}