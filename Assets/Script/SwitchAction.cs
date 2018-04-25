using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAction : MonoBehaviour {
	
	public GameObject Switch;
	public string AnimationText;
	public bool isOpened = false;

	void Update () {
		Collider[] hitColliders = Physics.OverlapBox(transform.position, new Vector3(0.3f,0.15f,0.3f));
		foreach (Collider ele in hitColliders) {
			if (ele.tag == "Box" || ele.tag == "Player") {
				Switch.GetComponent<Animator> ().SetBool (AnimationText, true);
				isOpened = true;
				break;
			} else {
				Switch.GetComponent<Animator> ().SetBool (AnimationText, false);
				isOpened = false;
			}
		}
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireCube(transform.position, new Vector3(0.3f,0.15f,0.3f));
	}
}
