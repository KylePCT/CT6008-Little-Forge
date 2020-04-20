//////////////////////////////////////////////////
/// File: PlantGrowth.cs
/// Author: Kyle Tugwell
/// Date created: 15/04/20
/// Last edit: 20/04/20
/// Description: Allows the crops to grow and be harvested.
/// Comments: 
//////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PlantGrowth : MonoBehaviour
{
    private InputSystem inputSystem;
    public GameObject interactText;
    private bool inRange;

    [Tooltip("This is the model and material of the crop.")]
    public Mesh cropMesh;
    public Material cropMaterial;

    [Header("Scale Attributes; Actual Scale is 1.")]
    [Tooltip("This dictates the size of the crop when it is planted. x0.1 = 1/10th of the actual size.")]
    [Range(0.05f, 0.3f)]
    public float startCropSize = 0.1f;

    [Tooltip("This dictates the size of the crop when it is fully grown. x1 is the actual size.")]
    [Range(0.5f, 1.5f)]
    public float endCropSize = 1f;

    [Tooltip("This dictates the growth rate of the crop.")]
    [Range(0f, 0.3f)]
    public float cropGrowthRate = 0.1f;

    public float rotationRate = 30f;

    //RNG for plant variance
    private float cropVariance;

    //particle system 
    private ParticleSystem fullyGrownPS;

    //check if the crop is grown
    private bool isHarvestable;

    //Initialize the mesh elements
    private void Start()
    {
        interactText = GameObject.Find("NewCanvas/InteractText");

        fullyGrownPS = GetComponent<ParticleSystem>();
        GetComponent<MeshFilter>().mesh = cropMesh;
        GetComponent<Renderer>().material = cropMaterial;

        //create some variance for the growth rate
        cropVariance = Random.Range(cropGrowthRate * 0.5f, cropGrowthRate * 1.5f);
    }

    //set the object scale to the startCropSize
    void Awake()
    {
        inputSystem = new InputSystem();

        transform.localScale = new Vector3(startCropSize, startCropSize, startCropSize);
    }

    private void OnEnable() => inputSystem.Player.Enable();
    private void OnDisable() => inputSystem.Player.Disable();


    void Update()
    {
        //if the scale is less than the designated full crop size
        if (transform.localScale.x < endCropSize)
        {
            //grow the object by growth rate
            transform.localScale += new Vector3(cropGrowthRate, cropGrowthRate, cropGrowthRate) * Time.deltaTime * (cropGrowthRate + cropVariance);

            transform.Rotate(0, 0, rotationRate * Time.deltaTime);

            isHarvestable = false;
        }
        
        //if it is less/more than the full crop size
        else
        {
            playParticles();
        }
    }

    //play particles and change isHarvestable to true
    void playParticles()
    {
        fullyGrownPS.Play();
        isHarvestable = true;
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player" && isHarvestable == true)
        {
            inRange = true;
            interactText.GetComponent<TextMeshProUGUI>().text = "Press 'F' to harvest crop!";
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

    void InteractKey(InputAction.CallbackContext ctx)
    {
        if (isHarvestable == true)
        {
            Debug.Log("Crop harvested");
            Destroy(this);
            //give player money or plants or whatever in their inventory
        }

        {
            Debug.Log("Crop not harvested");
            interactText.GetComponent<TextMeshProUGUI>().text = "This crop isn't mature yet!";
            interactText.SetActive(true);
        }
    }

    public bool checkIfHarvestable()
    {
        return isHarvestable;
    }

    public void DestroyMe()
    {
        Destroy(this.gameObject);
        Debug.Log("Crop harvested.");
    }
}
