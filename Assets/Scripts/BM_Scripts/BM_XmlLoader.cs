using System.Xml;
using UnityEngine;

public class BM_XmlLoader : MonoBehaviour { 

    public string GetNodePathValue(XmlNode nodePath) {
        string pathValue = nodePath.Value;
        return pathValue;
    }

    public string GetNodeText(XmlNode nodePath) {
        string text = nodePath.InnerText;
        return text;
    }

    public static XmlNodeList LoadXMLdata() {
        TextAsset xmlData = (TextAsset)Resources.Load(BM_Constants.XmlData);
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(xmlData.text);

        return xmlDocument.ChildNodes;
    }
}