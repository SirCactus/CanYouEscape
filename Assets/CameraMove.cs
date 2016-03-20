using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	//public Transform follow;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void FixedUpdate () {
//		this.position = new Vector3(follow.position.x, this.transform.position.y,this.transform.position.z);
		this.transform.Translate (.25f,0f,0f);
	}
}