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
    public GameObject plantedCrop;
    bool cropPlanted = false;
    [SerializeField] Transform placeToGrow;
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
    }

    private void OnTriggerStay(Collider col)
    {

        if (col.gameObject.tag == "Player" && cropPlanted == false)
        { 
            inRange = true;
            interactText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to plant crop!";
            interactText.SetActive(true);
        }
        else if(col.gameObject.tag == "Player" && cropPlanted == true && plantedCrop.GetComponent<PlantGrowth>().checkIfHarvestable() == false)
        {
            interactText.GetComponent<TextMeshProUGUI>().text = "Crop Isnt Ready!";
            interactText.SetActive(true);
        }
        else if (col.gameObject.tag == "Player" && cropPlanted == true && plantedCrop.GetComponent<PlantGrowth>().checkIfHarvestable() == true)
        {
            interactText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to harvest Crop!";
            interactText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        Debug.Log("Called");
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

            if (ctx.performed && cropPlanted == false)
            {
                plantedCrop = new GameObject();
                plantedCrop = Instantiate(cropToGrow, placeToGrow.position, placeToGrow.rotation);
               // plantedCrop = Instantiate(cropToGrow, new Vector3(Player.transform.position.x, 67.47f, Player.transform.position.z), Quaternion.identity);
                cropPlanted = true;

                Debug.Log("Crop planted.");
            }
        }

        if(ctx.performed && plantedCrop.GetComponent<PlantGrowth>().checkIfHarvestable() == true)
        {
            //harvest crop
            plantedCrop.GetComponent<PlantGrowth>().DestroyMe();
            plantedCrop = null;
            cropPlanted = false;
            interactText.SetActive(false);
        }
        //handle harvesting override
    }
}
