﻿//Sam Baker
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MultiMovementV2 : MonoBehaviour
{
    //Variable for Tom
    public Vector3 playerAccelaration;

    public float moveSpeed = 7.5f;

    private Vector3 jump;
    [SerializeField] private float jumpForce = 8.0f;
    [SerializeField] private float gravity = 20.0f;
    public bool isGrounded;
    //private Rigidbody rb;
    private bool leftStickPress;

    public GameObject playerOrientation;
    public GameObject playerFace;

    private float heading;

    private Vector3 moveDirection = Vector3.zero;
    private Vector3 jumpDirection = Vector3.zero;
    private bool shouldJump = false;
    private CharacterController controller;

    private Controls controls = null;

    [SerializeField] private Animator placeholderAnims;

    private void Awake() => controls = new Controls();

    private void OnEnable() => controls.Player.Enable();

    private void OnDisable() => controls.Player.Disable();

    private void Start() {
        leftStickPress = false;
        jump = new Vector3(transform.position.x, transform.position.y + 2.0f, transform.position.z);
        controller = GetComponent<CharacterController>();
        //rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        Move();
        if (GetComponent<PlayerZoomIn>().zoomIn) {
            moveSpeed = 5.0f;
        }
    }

    public void Jump(InputAction.CallbackContext ctx) {
        if (ctx.performed) {
            if (isGrounded) {
                Debug.Log("jump");
                shouldJump = true;
                isGrounded = false;
                //transform.position = new Vector3(transform.position.x, transform.position.y + 2.0f, transform.position.z);
                //rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                //GetComponent<Rigidbody>().AddForce(jump * jumpForce, ForceMode.Impulse);
            }
        }
    }

    public void LeftStickPress(InputAction.CallbackContext ctx) {
        if (ctx.performed) {
            Debug.Log("Press");
            if (leftStickPress) {
                moveSpeed = 7.5f;
                leftStickPress = false;
            } else {
                moveSpeed = 12.5f;
                leftStickPress = true;
            }
        }
    }

    private void Move() {
        var movementInput = controls.Player.Movement.ReadValue<Vector2>();

        Vector3 rotF = playerOrientation.transform.forward;
        Vector3 rotR = playerOrientation.transform.right;
        rotF.y = 0;
        rotR.y = 0;
        rotF = rotF.normalized;
        rotR = rotR.normalized;
        playerFace.transform.position = transform.position + (rotF * movementInput.y + rotR * movementInput.x) * 100 * Time.deltaTime;
        if (GetComponent<PlayerZoomIn>().zoomIn) {
            Vector3 playerYRot = playerOrientation.transform.eulerAngles;
            playerYRot.x = transform.eulerAngles.x;
            playerYRot.z = transform.eulerAngles.z;
            transform.eulerAngles = playerYRot;
        } else {
            transform.LookAt(playerFace.transform.position);
        }
        //transform.position += (rotF * movementInput.y + rotR * movementInput.x) * moveSpeed * Time.deltaTime;
        moveDirection = (rotF * movementInput.y + rotR * movementInput.x) * moveSpeed;
        if (shouldJump) {
            jumpDirection.y = jumpForce;
            shouldJump = false;
        }
        jumpDirection.y -= gravity * Time.deltaTime;
        controller.Move((moveDirection + jumpDirection) * Time.deltaTime);
        //Variable for Tom
        playerAccelaration = rotF * movementInput.y + rotR * movementInput.x *moveSpeed;

        //Animation conntroller
        if (movementInput.magnitude == 0) {
            placeholderAnims.SetBool("isRunning", false);
        } else {
            placeholderAnims.SetBool("isRunning", true);
        }
    }

    void OnCollisionStay(Collision col) {
        if (col.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            shouldJump = true;
        }
    }
}
