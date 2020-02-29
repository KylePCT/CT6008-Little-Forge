using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BM_CharacterController : MonoBehaviour {
    public float movementSpeed, rotationSpeed, jumpForce;

    public GameObject groundCheck;

    public static bool isGrounded, isAiming = false;
    private Rigidbody rb;

    private Transform cam;

    void Start() {
        rb = GetComponent<Rigidbody>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse1)) {
            if (isAiming) {
                isAiming = false;
            } else {
                isAiming = true;
                Vector3 camEuler = cam.rotation.eulerAngles;
                transform.eulerAngles = new Vector3(0, camEuler.y, 0);
            }
        } 
    }

    void FixedUpdate() {
        Movement();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            Jump();
        }
    }

    void Movement() {
        float translation = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, translation);

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }

    void Jump() {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
