using UnityEngine;
using System.Collections;

public class MoveMent : MonoBehaviour {

	void FixedUpdate(){
		this.transform.Translate (.25f,0f,0f);
		if (Input.GetKey("w")&& this.yFromCamera()<2.0f){
			this.transform.Translate (0f,.2f,0f);
		}
		else if (Input.GetKey("s")&& this.yFromCamera()>-2.0f){
			this.transform.Translate (0f,-.2f,0f);
		}
		if (Input.GetKey("a")&& this.xFromCamera()<2.0f){
			this.transform.Translate (-.2f,0f,0f);
		}
		else if (Input.GetKey("d")&& this.xFromCamera()>-2.0f){
			this.transform.Translate (.2f,0f,0f);
		}
	}

	float xFromCamera(){
		Debug.Log (this.transform.position.x - Camera.main.transform.position.x);
		return ((this.transform.position.x)-(Camera.main.transform.position.x));
	}

	float yFromCamera(){
		Debug.Log ((this.transform.position.y)-(Camera.main.transform.position.y));
		return ((this.transform.position.y)-(Camera.main.transform.position.y));
	}
}