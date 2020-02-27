
using UnityEngine;

public class BM_CameraController : MonoBehaviour {
    private Transform player;
    public Vector3 normalOffset, aimingOffset;
    private bool offsetChanged = false;
    private bool angleChanged = false;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        transform.localPosition = normalOffset;
    }

    private void Update() {
        if (BM_CharacterController.isAiming) {
            transform.localPosition = aimingOffset;
            if (!angleChanged) {
                angleChanged = true;
                transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            offsetChanged = false;
            Camera.main.fieldOfView = 40;
        } else {
            if (!offsetChanged) {
                transform.localPosition = normalOffset;
                offsetChanged = true;
                angleChanged = false;
            }
            Camera.main.fieldOfView = 60;
            transform.LookAt(player);
        }
    }
}
