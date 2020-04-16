using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PlantSoil : MonoBehaviour

{
    private InputSystem inputSystem;
    private bool inRange;
    public GameObject Player;

    [Tooltip("This is the prefab of the crop model, material and script.")]
    public GameObject cropToGrow;

    [SerializeField] private GameObject interactText = null;

    private void Start()
    {
        interactText = GameObject.Find("InteractText");
    }
    private void Awake() => inputSystem = new InputSystem();
    private void OnEnable() => inputSystem.Player.Enable();
    private void OnDisable() => inputSystem.Player.Disable();

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 9;

        //invert layermask
        layerMask = ~layerMask;
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player" && col.gameObject.tag != "Crop")
        { 
            inRange = true;
            interactText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to plant crop!";
            interactText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            interactText.SetActive(false);
            inRange = false;
        }
    }

    public void InteractKey(InputAction.CallbackContext ctx)
    {
        if (inRange)
        {
            Debug.Log("In range to plant.");

            if (ctx.performed && Physics.OverlapSphere(transform.position, 1f).Length > 0)
            {
                GameObject plantedCrop = Instantiate(cropToGrow, Player.transform.position, Quaternion.identity);
                Debug.Log("Crop planted.");
            }
        }
    }
}
