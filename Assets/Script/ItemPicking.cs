using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicking : MonoBehaviour {
	void Start () {
		box = null;
	}
	GameObject box;
	public Transform boxPlacement;
	void Update () {
		if (box) {
			box.transform.position = boxPlacement.position;
			if (Input.GetKeyDown (KeyCode.Space)) {
				box.GetComponent<Rigidbody> ().isKinematic = false;
				box.GetComponent<BoxCollider> ().enabled = true;
				box = null;
			}
		} else {
			if (Input.GetKeyDown (KeyCode.Space)) {
				Collider[] hitColliders = Physics.OverlapSphere(transform.position, 0.5f);
				int i = 0;
				while (i < hitColliders.Length){
					if(hitColliders[i].tag == "Box"){
						box = hitColliders [i].gameObject;
						box.transform.position = boxPlacement.position;
						box.GetComponent<Rigidbody> ().isKinematic = true;
						box.GetComponent<BoxCollider> ().enabled = false;
						break;
					}
					i++;
				}
			}
		}
	}
	void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(transform.position, 0.5f);
	}
}
