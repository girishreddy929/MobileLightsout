using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Collections.Generic;

public class levelHandler : MonoBehaviour {

	XmlDocument levelDoc;
	XmlNodeList levelList;
	List<string> levelArray;

	// Use this for initialization
	void Start () {

		levelArray = new List<string> ();
		levelDoc = new XmlDocument();
		TextAsset xmlfile = Resources.Load ("levels", typeof(TextAsset)) as TextAsset;
		levelDoc.LoadXml (xmlfile.text);
		levelList = levelDoc.GetElementsByTagName("level");
		foreach (XmlNode leveldata in levelList) {
			XmlNodeList levelinfo = leveldata.ChildNodes;
			Debug.Log (levelList.Count);
			foreach (XmlNode data in levelinfo) {
				Debug.Log(data.Name);
				if(data.Name == "setup"){
					Debug.Log(data.InnerText);
					levelArray.Add(data.InnerText);
				}
			}

		}

	}

	// Update is called once per frame
	void Update () {

	}

	public void loadLevel(int nr){

		string[] levString = levelArray [nr - 1].Split(',');
		foreach (string brick in levString){
			GameObject.Find(brick).GetComponent<lightSwitch>().change();
		}

	}
}
