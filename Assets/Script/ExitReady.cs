using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitReady : MonoBehaviour {

	public SwitchAction[] sa;
	// Use this for initialization
	void Start () {
		
	}
	public bool finished = false;
	// Update is called once per frame
	void Update () {
		foreach (SwitchAction ele in sa) {
			if (!ele.isOpened) {
				finished = false;
				break;
			} else {
				finished = true;
			}
		}
		if (finished) {
			GetComponent<MeshRenderer> ().enabled = true;
		} else {
			GetComponent<MeshRenderer> ().enabled = false;
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player"){
			Debug.Log ("You Win");
			// level up 
			// cavas You Win 
			// Map navi
		}
	}
}
