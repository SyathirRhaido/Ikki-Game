using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speedMove;

	private Rigidbody2D myRB;

	private Animator myAnim;

	bool flag;


//	public float lastTouchTime, currentTouchTime;

	public float velocityValue, torqueValue, thresholdTime;

	void Awake(){
		velocityValue = 1.0f;
		torqueValue = 200.0f;
		thresholdTime = 0.3f;
	}


	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody2D> ();

		myAnim = GetComponent<Animator> ();

		flag = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		MovePlayer ();
	
	}

	void MovePlayer(){

		Vector3 currentPos, touchedPos, distanceVec;
		 if(Input.GetMouseButtonUp(0)){
//			Debug.Log ("touch");
			currentPos = Camera.main.WorldToScreenPoint (transform.position);
			touchedPos = Input.mousePosition;
			distanceVec = (touchedPos - currentPos).normalized;
			stopRotatingCatAndMoveIt(distanceVec, velocityValue);
		}
	}
		

	void stopRotatingCatAndMoveIt(Vector3 distanceVec, float velocity){
		//we stop rotating ....
		Quaternion catQuatern = new Quaternion();
		catQuatern.eulerAngles = new Vector3(0,0,0);
		// ... and move it ..
		myRB.velocity = distanceVec*velocity;
	}

}
