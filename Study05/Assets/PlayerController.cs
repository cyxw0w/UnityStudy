using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float Velocity;

    Vector3 dir;
    public float xInput;
    public float zInput;

    public Rigidbody playerRigidBody;
    public float speed = 8f;

    public Animator anim;
    public Camera cam;
    public CharacterController controller;

    public float Speed;
    public float allowPlayerRotation = 0.1f;

    public Vector3 desiredMoveDirection;
    public float desiredRotationSpeed = 0.1f;

    public float StartAnimTime = 0.3f;
    
    public float StopAnimTime = 0.15f;

    public bool blockRotationPlayer;

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();

        anim = this.GetComponent<Animator>();
        cam = Camera.main;
        controller = this.GetComponent<CharacterController>();
    }

    void PlayerMoveAndRotation()
    {
        dir = new Vector3(xInput, 0, zInput) * speed;

        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMoveDirection), desiredRotationSpeed);
            print("È¸Àü");
            controller.Move(desiredMoveDirection * Time.deltaTime * Velocity);
        }
    }

    // Update is called once per frame
    void Update()
    {       
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);


        Speed = new Vector2(xInput, zInput).sqrMagnitude;

        if (Speed > allowPlayerRotation)
        {
            print("1");
            anim.SetFloat("Blend", Speed, StartAnimTime, Time.deltaTime);
            PlayerMoveAndRotation();
        }
        else if (Speed < allowPlayerRotation)
        {
            print("2");
            anim.SetFloat("Blend", Speed, StopAnimTime, Time.deltaTime);
        }

        playerRigidBody.velocity = newVelocity;
    }
}
