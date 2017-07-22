using UnityEngine;
using System.Collections;

public class FlySprite : MonoBehaviour {

	private float karakterForce = 10.5f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		bool karakterActive = Input.GetButton ("Fire1");

		if(karakterActive){

			GetComponent<Rigidbody2D>().AddForce (new Vector2(0, karakterForce));
		}
	}
}
