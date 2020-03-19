
using System.Xml;
using UnityEngine;

public class BM_DialogueSystem : MonoBehaviour {
    [SerializeField] private string dialogueStoryName;

    private XmlNodeList dialogueData;
    
    private int dialogueID = 0;
    private int destinationID = 0;
    public string dialogueLine { get; private set; }

    private void Awake() {
        dialogueData = BM_XmlLoader.LoadXMLdata();
        Debug.Log(dialogueData);
        dialogueData = dialogueData[1].SelectNodes(BM_Constants.Dialogue);
    }

    public void GetNextDialogue() {
        string stringDialogueID = dialogueData[dialogueID].SelectSingleNode(BM_Constants.XmlDialogueID).Value;
        dialogueID =  int.Parse(stringDialogueID);


        string stringDestinationID = dialogueData[dialogueID].FirstChild.SelectSingleNode(BM_Constants.XmlDialogueDestinationID).Value;
        destinationID = int.Parse(stringDestinationID);

        dialogueLine = dialogueData[dialogueID].SelectSingleNode(BM_Constants.Line).InnerText;

        Debug.Log(dialogueLine);

        dialogueID = destinationID;
    }
}
