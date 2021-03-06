﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	
	private Vector2 velocity;

	public float smoothTimeY;
	public float smoothTimeX;

	public GameObject player;

	public bool bounds;

	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;

	// Use this for initialization
	void Start () {
		//GetComponent<Camera> ().orthographicSize = Screen.height / (2*32f) / 2f;

		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float posX = Mathf.SmoothDamp (transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
		float posY = Mathf.SmoothDamp (transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

		transform.position = new Vector3 (posX, posY, transform.position.z);

		if(bounds){
//			transform.position = new Vector3 (Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x));
			Mathf.Clamp (transform.position.y, minCameraPos.y, maxCameraPos.y);
			Mathf.Clamp (transform.position.x, minCameraPos.x, maxCameraPos.x);
		}
	}
}
