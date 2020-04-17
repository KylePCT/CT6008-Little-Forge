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

    [SerializeField] List<GameObject> Crops;
    GameObject harvestedPlant;

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
        
        bool isAnyPlanted = false;

        foreach (GameObject crop in Crops)
            {
        if(crop.GetComponent<PlantGrowth>().checkIfHarvestable() == true)
            {
                isAnyPlanted = true;
                break;
            }
        }


        if (col.gameObject.tag == "Player" && isAnyPlanted == false)
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
                Crops.Add(plantedCrop);

                Debug.Log("Crop planted.");
            }
        }

        //handle harvesting override

        bool isAnyPlanted = false;

        foreach (GameObject crop in Crops)
        {
            if (crop.GetComponent<PlantGrowth>().checkIfHarvestable() == true)
            {
                isAnyPlanted = true;
                harvestedPlant = crop;
                Crops.Remove(harvestedPlant);
                break;
            }
        }

       if(isAnyPlanted)
        {
            harvestedPlant.GetComponent<PlantGrowth>().DestroyMe();
            harvestedPlant = null;
        }
    }
}
