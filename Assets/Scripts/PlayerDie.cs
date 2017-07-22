using UnityEngine;
using System.Collections;

public class PlayerDie : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.tag == "Player"){
			Destroy (other.gameObject);
		}
	}

	void GameOver(){
		Application.LoadLevel (1);
	}
}
