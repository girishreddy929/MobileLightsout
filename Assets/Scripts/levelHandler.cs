using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Collections.Generic;

public class levelHandler : MonoBehaviour {

	XmlDocument levelDoc;
	XmlNodeList levellist;
	List<string> levelArray;

	// Use this for initialization
	void Start () {


		levelArray = new List<string> ();
		levelDoc = new XmlDocument ();
		TextAsset xmlfile = Resources.Load ("levels", typeof(TextAsset)) as TextAsset;
		levelDoc.LoadXml (xmlfile.text);
		levellist = levelDoc.GetElementsByTagName ("level");

		foreach (XmlNode leveldata in levellist) {
			XmlNodeList levelinfo = leveldata.ChildNodes;
			Debug.Log (levellist.Count);
			foreach (XmlNode data in levelinfo) {
				Debug.Log (data.InnerText);
				if (data.Name == "setup") {
					Debug.Log (data.Name);
					levelArray.Add (data.InnerText);
				}
			}
		}
	}
	public void loadLevel(int nr){

		string[] levString = levelArray [nr - 1].Split (',');
		foreach (string brick in levString) {
			GameObject.Find (brick).GetComponent<lightSwitch>().change ();
		}
	}


	// Update is called once per frame
	void Update () {

	}
}
