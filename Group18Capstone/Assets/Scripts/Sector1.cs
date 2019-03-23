using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// author: kinan gh
// published: Nov 20, 2016
// source: https://www.youtube.com/watch?v=fKWTpi70a_E

public class Sector1 : MonoBehaviour
{
    public Transform[] target;
    public float speed;

    private int current;

    private void Start()
    {

    }

    void Update()
    {
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % target.Length;
        }
    }
}