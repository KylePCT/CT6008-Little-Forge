//////////////////////////////////////////////////
/// File: PlantSoil.cs
/// Author: Kyle Tugwell/Sam Baker
/// Date created: 15/04/20
/// Last edit: 27/05/20
/// Description: Code to plant the seed in.
/// Comments: Reworked to rid errors and adopt clean system
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PlantSoil : MonoBehaviour
{
    private InputSystem m_inputSystem;
    private bool m_inRange;
    public GameObject Player;

    [Tooltip("This is the prefab of the crop model, material and script.")]
    public GameObject soilArea;
    public Material soilMat;
    public Material soilCanPlant;
    public Material soilCantPlant;

    public GameObject cropToGrow;
    public GameObject plantedCrop;
    public Item m_seedsNeeded;
    bool m_cropPlanted = false;
    private float m_timer = 2.0f; //The amount of seconds texts pops up saying not enough seeds
    private bool m_seedCheck = false;
    [SerializeField] Transform placeToGrow;
    [SerializeField] private GameObject interactText;

    [SerializeField] private Item m_item0 = null;
    [SerializeField] private Item m_item1 = null;
    [SerializeField] private int m_minRange, m_maxRange = 0;


    private void Awake() => m_inputSystem = new InputSystem();
    private void OnEnable() => m_inputSystem.Player.Enable();
    private void OnDisable() => m_inputSystem.Player.Disable();
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        soilArea = this.gameObject;
    }
    private void Update()
    {
        InteractionKey();
    }
    private void OnTriggerStay(Collider col)
    {
        PlantCheck(col);
    }

    //if the player leaves the collision
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            interactText.SetActive(false);
            m_inRange = false;
            m_seedCheck = false;

            soilArea.GetComponent<MeshRenderer>().material = soilMat;
        }
    }

    private void PlantCheck(Collider a_col)
    {
        //is the crop is not planted, show text to prompt it
        if(a_col.gameObject.tag == "Player")
        {
            m_inRange = true;

            if (m_cropPlanted == false)
            {
                if (!m_seedCheck)
                {
                    interactText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to plant crop!";
                    interactText.SetActive(true);

                    soilArea.GetComponent<MeshRenderer>().material = soilCanPlant;

                }
                else
                {
                    interactText.GetComponent<TextMeshProUGUI>().text = "Not enough seeds!";
                    interactText.SetActive(true);
                    soilArea.GetComponent<MeshRenderer>().material = soilCantPlant;

                    m_timer -= Time.deltaTime;
                    if (m_timer <= 0)
                    {
                        m_seedCheck = false;
                        soilArea.GetComponent<MeshRenderer>().material = soilCantPlant;

                        interactText.SetActive(false);

                    }
                }
            }
            //if it is planted
            else
            {
                if (plantedCrop.GetComponent<PlantGrowth>().checkIfHarvestable() == false)
                {
                    //Planted but not fully grown
                    interactText.GetComponent<TextMeshProUGUI>().text = "Crop Isnt Ready!";
                    interactText.SetActive(true);
                }
                else
                {
                    //if it is fully grown
                    interactText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to harvest Crop!";
                    interactText.SetActive(true);
                }
            }
        }
    }

    void InteractionKey()
    {
        if (m_inputSystem.Player.Interact.triggered)
        {
            if (m_inRange)
            {
                if (m_cropPlanted == false)
                {
                    if (InventoryManager.instance.RemoveItem(m_seedsNeeded))
                    {
                        plantedCrop = new GameObject();
                        plantedCrop = Instantiate(cropToGrow, placeToGrow.position, placeToGrow.rotation);
                        plantedCrop.transform.parent = placeToGrow.transform;
                        plantedCrop.GetComponent<PlantGrowth>().m_item0 = m_item0;
                        plantedCrop.GetComponent<PlantGrowth>().m_item1 = m_item1;
                        plantedCrop.GetComponent<PlantGrowth>().m_minRange = m_minRange;
                        plantedCrop.GetComponent<PlantGrowth>().m_maxRange = m_maxRange;

                        m_cropPlanted = true;

                        interactText.SetActive(false);

                    }
                    else
                    {
                        m_seedCheck = true;
                        m_timer = 2.0f;
                        interactText.GetComponent<TextMeshProUGUI>().text = "Not enough seeds!";
                        interactText.SetActive(false);
                    }
                }
                else
                {
                    if (plantedCrop.GetComponent<PlantGrowth>().checkIfHarvestable() == true)
                    {
                        //harvest crop
                        Debug.Log("Should Be Destroyed");
                        plantedCrop.GetComponent<PlantGrowth>().DestroyMe();
                        plantedCrop = null;
                        m_cropPlanted = false;

                        //Destroy the child of the placeToGrow (the crop gameobject) -KT 27/05
                        var child = placeToGrow.GetChild(0);
                        Destroy(child.gameObject);

                        interactText.SetActive(false);
                    }
                }
            }
        }
    }
}
