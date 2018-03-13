using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {
	public SteamVR_TrackedObject myController;
	public int myIndex;
	public GameObject spellWheel;
	// Use this for initialization
	void Start () {
		//get index of controller this script is on
		myController = GetComponent<SteamVR_TrackedObject>();
		myIndex = (int)myController.index;
		
	}
	
	// Update is called once per frame
	void Update () {
		//if the touchpad is touched show the spell wheel
		if (SteamVR_Controller.Input(myIndex).GetTouch(SteamVR_Controller.ButtonMask.Touchpad)){
			spellWheel.SetActive(true);
		}
		else {
			spellWheel.SetActive(false);
		}
	}

	/*im putting this here because i can never remember it: getting input from steamvr controllers
	 * 
	 if (SteamVR_Controller.Input (index).GetPress (SteamVR_Controller.ButtonMask.whateverbutton)) {

	} 
	 
	*/
}
