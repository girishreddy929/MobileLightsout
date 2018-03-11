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
	
		if (isOn) {
			isOn = false;
			this.transform.localEulerAngles = new Vector3 (0, 45, 0);
		} else {
			isOn = true;
			this.transform.localEulerAngles = Vector3.zero;
		}
	}
}
