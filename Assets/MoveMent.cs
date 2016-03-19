using UnityEngine;
using System.Collections;

public class MoveMent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		this.transform.Translate (.25f,0f,0f);
		if (Input.GetKey("w")){
			this.transform.Translate (0f,1f,0f);
		}
		else if (Input.GetKey("s")){
			this.transform.Translate (0f,-1f,0f);
		}
		else if (Input.GetKey("a")){
			this.transform.Translate (-1f,0f,0f);
		}
		else if (Input.GetKey("d")){
			this.transform.Translate (1f,0f,0f);
		}
	}
}