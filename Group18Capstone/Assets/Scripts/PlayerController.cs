using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private CharacterController cController;
    public float Speed = 5.0f;
    public float rSpeed = 240.0f;
    private float Gravity = 20.0f;
    private Vector3 moveD = Vector3.zero;

    void Start()
    {
        anim = GetComponent<Animator>();
        cController = GetComponent<CharacterController>();
    }

  
    void Update()
    {
        
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 camForward_Dir = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 move = ver * camForward_Dir + hor * Camera.main.transform.right;

        if (move.magnitude > 1f) 
            move.Normalize();

            move = transform.InverseTransformDirection(move);
            float turnAmount = Mathf.Atan2(move.x, move.z);
             transform.Rotate(0, turnAmount *  rSpeed * Time.deltaTime, 0);

        if (cController.isGrounded)
        {
            anim.SetBool("run", move.magnitude> 0);
            moveD = transform.forward * move.magnitude;
            moveD *= Speed;
        }

        moveD.y -= Gravity * Time.deltaTime;
        cController.Move(moveD * Time.deltaTime);
    }
}
