using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int count = 0;

		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				GameObject tmpGb = Instantiate (Resources.Load ("Cube", typeof(GameObject))) as GameObject;
				tmpGb.transform.position = new Vector3 (j * 1.5f - 3f, i * -1.5f + 3f, 0);
				tmpGb.name = count.ToString ();
				count++;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
