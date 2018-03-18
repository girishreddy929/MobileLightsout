using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engine : MonoBehaviour {

	int nrOfLevels;
	public int currentLevel;
	public int nrOfMoves=0;
	// Use this for initialization
	void Start () {
		PlayerPrefs.DeleteAll ();
	}

	public void init(int nr){
		nrOfLevels = nr;
		currentLevel = getProgress ();
	}

	// Update is called once per frame
	void Update () {

	}

	int getProgress(){
		int progint = 0;

		for (int i = 1; i<nrOfLevels+1; i++) {

			Debug.Log (i);

			if(PlayerPrefs.HasKey(i.ToString())){
				progint = i;
			}else{
				progint++;
				break;
			}
		}

		return progint;
	}

	int getScore(string lev){
		return PlayerPrefs.GetInt (lev);
	}

	void saveScore(){

		if (PlayerPrefs.HasKey (currentLevel.ToString ())) {
			if(getScore(currentLevel.ToString ())>nrOfMoves){
				PlayerPrefs.SetInt(currentLevel.ToString (), nrOfMoves);
			}
		}else{
			PlayerPrefs.SetInt(currentLevel.ToString (), nrOfMoves);
		}
	}

	public void startGame () {
		this.gameObject.GetComponent<levelHandler> ().loadLevel (currentLevel);
	}

	public void gameFinished(){
		saveScore ();
		currentLevel++;
		nrOfMoves = 0;
		this.gameObject.GetComponent<levelHandler> ().loadLevel (currentLevel);
	}


}
