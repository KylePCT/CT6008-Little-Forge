//Sam Baker
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerZoomIn : MonoBehaviour
{
    [SerializeField] private GameObject cam;
    public GameObject crossHair;
    private Vector3 origPos;
    private Quaternion origRot;
    public bool zoomIn;
    public Weapon gun;
    [SerializeField] private float zoomSpeed = 5.0f;

    public Animator placeholderAnims;


    private void Start() {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        crossHair.SetActive(false);
        origPos = cam.transform.localPosition;

        //placeholderAnims = GetComponent<Animator>();
    }

    private void Update() {
        if (zoomIn) {
            if(gun.isShooting)
            {
                //shooting
                placeholderAnims.SetBool("isShooting", true);
                Debug.Log("blap");
            }
            else
            {
                placeholderAnims.SetBool("isShooting", false);
            }
            cam.transform.localPosition = Vector3.Lerp(cam.transform.localPosition, new Vector3(1.3f, 1.6f, -2.5f), zoomSpeed * Time.deltaTime);
        } else {
            cam.transform.localPosition = Vector3.Lerp(cam.transform.localPosition, origPos, zoomSpeed * Time.deltaTime);
        }
    }

    public void ZoomIn(InputAction.CallbackContext ctx) {
        if(ctx.performed) {
            if(zoomIn) {
                //ZoomOut
                cam.transform.localRotation = origRot;
                crossHair.SetActive(false);
                zoomIn = false;
                GetComponent<MultiMovementV2>().moveSpeed = 7.5f;
            } else {
                //ZoomIn
                origRot = cam.transform.localRotation;
                cam.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                crossHair.SetActive(true);
                zoomIn = true;
                GetComponent<MultiMovementV2>().moveSpeed = 5.0f;
            }
        }
    }   
}
