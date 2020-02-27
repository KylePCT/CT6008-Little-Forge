using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BM_CameraParent : MonoBehaviour {

    public float mouseRotationSpeed;
    private float yaw = 0.0f, pitch = 0.0f;

    public float minPitch, maxPitch;

    private Transform player;
    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!BM_CharacterController.isAiming) {
            yaw += mouseRotationSpeed * Input.GetAxis("Mouse X");
            pitch -= mouseRotationSpeed * Input.GetAxis("Mouse Y");

            pitch = Mathf.Clamp(pitch, minPitch, maxPitch);

            transform.eulerAngles = new Vector3(pitch, yaw, 0);
        } else {
            Vector3 temp = transform.rotation.eulerAngles;
            transform.eulerAngles = new Vector3(0, temp.y, 0);
        }

        transform.position = new Vector3 (player.position.x, transform.position.y, player.position.z);
    }
}
