using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour {

	public bool isOn = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void change(){
	
		Vector3 curPos = this.transform.Find ("Plane1").position;
		if (isOn) {
			isOn = false;
			this.transform.Find ("Plane1").position = new Vector3 (curPos.x, curPos.y, curPos.z+.5f );
			Debug.Log ("Changed To False");
		} else {
			isOn = true;
			this.transform.Find ("Plane1").position = new Vector3 (curPos.x, curPos.y, curPos.z -.5f);
			Debug.Log ("Changed To True");
		}
	}
}
