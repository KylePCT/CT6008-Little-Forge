//Sam Baker
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : MonoBehaviour
{
    public float rotSensitivity = 100.0f;
    public float origSensitivity;
    public Transform player;
    private float xAxisClamp;

    private bool locked = false;
    //private GameObject enemy;

    private Controls controls = null;

    private void Awake() => controls = new Controls();

    private void OnEnable() => controls.Player.Enable();

    private void OnDisable() => controls.Player.Disable();

    private void Start() => origSensitivity = rotSensitivity;

    private void Update() {
        transform.position = player.position;
        if (locked) {
            Debug.Log("Locked");
            //if (enemy != null) {
            //    transform.LookAt(enemy.transform.position);
            //} else {
            //    locked = false;
            //}
        } else {
            Debug.Log("Unlocked");
            Rotate();
        }
    }

    private void Rotate() {
        var rotationInput = controls.Player.Rotation.ReadValue<Vector2>();

        xAxisClamp += -1.0f * rotationInput.y * rotSensitivity * Time.deltaTime;
        if (xAxisClamp <= -15.0f) {
            xAxisClamp = -15.0f;
            ClampXAxisRotationToValue(-15.0f);
        } else if (xAxisClamp >= 45.0f) {
            xAxisClamp = 45.0f;
            ClampXAxisRotationToValue(45.0f);
        }

        var cameraRotation = new Vector3 {
            x = -1.0f * rotationInput.y,
            y = rotationInput.x
        };

        transform.Rotate(cameraRotation * rotSensitivity * Time.deltaTime);

        LockZAxisRotation();

        //SetPlayerRotation();
    }

    private void SetPlayerRotation() {
        if (controls.Player.Movement.triggered) {
            Vector3 playerYRot = player.transform.eulerAngles;
            playerYRot.y = transform.eulerAngles.y;
            player.transform.eulerAngles = playerYRot;
        }
    }

    private void ClampXAxisRotationToValue(float f_value) {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = f_value;
        transform.eulerAngles = eulerRotation;
    }

    private void LockZAxisRotation() {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.z = 0.0f;
        transform.eulerAngles = eulerRotation;
    }

    public void LockOn(InputAction.CallbackContext ctx) {
        if (ctx.performed) {
            //if (locked) {
            //    locked = false;
            //} else {
            //    if (GameObject.FindGameObjectWithTag("CrossHair").GetComponent<Crosshair>().enemyTarget != null) {
            //        enemy = GameObject.FindGameObjectWithTag("CrossHair");
            //        locked = true;
            //    }
            //}
            Debug.Log("Lock on needs work before enabling");
        }
    }
}
