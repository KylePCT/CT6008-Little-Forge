//Sam Baker
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{
    public Camera cam;
    public Image crosshair;

    public GameObject enemyTarget;

    public GameObject playerRotation;

    private Controls controls = null;

    private void Awake() => controls = new Controls();

    private void OnEnable() => controls.Player.Enable();

    private void OnDisable() => controls.Player.Disable();

    private void Start() {
        crosshair.color = Color.black;
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    private void Update() {
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100.0f)) {
            if (hit.transform.tag == "Enemy") {
                enemyTarget = hit.transform.gameObject;
                EnemyOnCrossHair();
            } else if (hit.transform.tag == "Follower") {
                FriendlyOnCrossHair();
            } else {
                ReturnCrossHair();
            }
        } else {
            ReturnCrossHair();
        }
    }

    private void FriendlyOnCrossHair() {
        crosshair.color = Color.green;
    }

    private void EnemyOnCrossHair() {
        crosshair.color = Color.red;
        playerRotation.GetComponent<PlayerRotation>().rotSensitivity = playerRotation.GetComponent<PlayerRotation>().origSensitivity - 25.0f;
    }

    private void ReturnCrossHair() {
        crosshair.color = Color.black;
        playerRotation.GetComponent<PlayerRotation>().rotSensitivity = playerRotation.GetComponent<PlayerRotation>().origSensitivity;
    }
}
