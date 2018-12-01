using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class predeterminedRoute : MonoBehaviour {
	public float velocity;
	private int currTarget;
	public Transform[] destination;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(transform.position != destination[currTarget].position){
			Vector3 pos = Vector3.MoveTowards(transform.position, destination[currTarget].position, velocity * Time.deltaTime);
			GetComponent<Rigidbody>().MovePosition(pos);
		}
		else
		{
			currTarget = (currTarget + 1) % destination.Length;
		}
		
	}
}
