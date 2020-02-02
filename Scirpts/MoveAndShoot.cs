using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    public float speed;
    public float gravity;
    public float jumpHeight;

    public float GroundDistance;
    public Transform GroundCheck;
    public LayerMask GroundMask;

    public VariableStruct checkPower;

    private CharacterController controller;
    private Vector3 velocity;

    private bool hasNotJumped = true;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (checkPower.GetPower("Wall") == false)
        {
            isGrounded = Physics.Raycast(GroundCheck.position, -Vector3.up, GroundDistance, GroundMask);
        }
        else
        {
            isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);
        }

        float horiz = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(horiz, 0, 0);

        controller.Move(move * speed * Time.deltaTime);

        Debug.Log(isGrounded);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -gravity * Time.deltaTime;
            velocity.x = 0;
            hasNotJumped = true;
        }

        if (Input.GetKeyDown(KeyCode.W) && checkPower.GetPower("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * 1.5f * gravity);
        }

        if (Input.GetKeyDown(KeyCode.W) && !isGrounded && /*checkPower.GetPower("DJ") &&*/ hasNotJumped)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * 2f * gravity);
            hasNotJumped = false;
        }

        velocity.y += gravity * Time.deltaTime * -1;
        controller.Move(velocity * Time.deltaTime);
    }
}
