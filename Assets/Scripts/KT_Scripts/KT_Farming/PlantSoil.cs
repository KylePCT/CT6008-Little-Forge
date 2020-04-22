//////////////////////////////////////////////////
/// File: PlantSoil.cs
/// Author: Kyle Tugwell
/// Date created: 15/04/20
/// Last edit: 20/04/20
/// Description: Code to plant the seed in.
/// Comments: 
//////////////////////////////////////////////////

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
    [SerializeField] private GameObject interactText;

    [SerializeField] private Item m_item0 = null;
    [SerializeField] private Item m_item1 = null;
    [SerializeField] private int m_minRange, m_maxRange = 0;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        interactText = GameObject.FindGameObjectWithTag("InteractText");
    }

    private void Awake() => inputSystem = new InputSystem();
    private void OnEnable() => inputSystem.Player.Enable();
    private void OnDisable() => inputSystem.Player.Disable();

    // Update is called once per frame
    void Update()
    {
    }

    //If the player is in the collision
    private void OnTriggerStay(Collider col)
    {
        //is the crop is not planted, show text to prompt it
        if (col.gameObject.tag == "Player" && cropPlanted == false)
        { 
            inRange = true;
            interactText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to plant crop!";
            interactText.SetActive(true);
        }
        //if it is planted but still growing
        else if(col.gameObject.tag == "Player" && cropPlanted == true && plantedCrop.GetComponent<PlantGrowth>().checkIfHarvestable() == false)
        {
            interactText.GetComponent<TextMeshProUGUI>().text = "Crop Isnt Ready!";
            interactText.SetActive(true);
        }
        //if it is fully grown
        else if (col.gameObject.tag == "Player" && cropPlanted == true && plantedCrop.GetComponent<PlantGrowth>().checkIfHarvestable() == true)
        {
            interactText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to harvest Crop!";
            interactText.SetActive(true);
        }
    }

    //if the player leaves the collision
    private void OnTriggerExit(Collider col)
    {
        Debug.Log("Called");
        if (col.gameObject.tag == "Player")
        {
            interactText.SetActive(false);
            inRange = false;
        }
    }

    //if the interact key is pressed (f in inputmanager)
    public void InteractKey(InputAction.CallbackContext ctx)
    {
        //if the player is in range
        if (inRange)
        {
            Debug.Log("In range to plant.");

            //and the interact key is pressed with no crop planted
            if (ctx.performed && cropPlanted == false)
            {
                plantedCrop = new GameObject();
                plantedCrop = Instantiate(cropToGrow, placeToGrow.position, placeToGrow.rotation);
                plantedCrop.transform.parent = placeToGrow.transform;
                plantedCrop.GetComponent<PlantGrowth>().m_item0 = m_item0;
                plantedCrop.GetComponent<PlantGrowth>().m_item1 = m_item1;
                plantedCrop.GetComponent<PlantGrowth>().m_minRange = m_minRange;
                plantedCrop.GetComponent<PlantGrowth>().m_maxRange = m_maxRange;

                cropPlanted = true;

                Debug.Log("Crop planted.");
            }
        }

        //check if the crop is fully grown
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
