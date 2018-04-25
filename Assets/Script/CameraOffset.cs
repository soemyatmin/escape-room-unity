using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOffset : MonoBehaviour {
	public Transform Player;

	Vector3 initPosition;
	// Use this for initialization
	void Start () {
		initPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Player.position + initPosition;
	}
}
