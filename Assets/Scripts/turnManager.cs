using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int count = 1;

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
		if (Input.GetMouseButtonUp (0)) {
			RaycastHit hit = new RaycastHit ();
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit, 100)) {
				makeMove (int.Parse (hit.collider.gameObject.name));
			}
		}
	}

	void makeMove(int name){
		turn (name);
		turn (name - 5);
		turn (name + 5);
		if (name % 5 != 0)
			turn (name + 1);
		if (name % 5 != 1)
			turn (name - 1);
	}

	void turn(int name){
		if (name < 1 || name > 25)
			return;
		GameObject turnObj = GameObject.Find (name.ToString ()).gameObject;
		turnObj.GetComponent<lightSwitch> ().change ();
	}
}
