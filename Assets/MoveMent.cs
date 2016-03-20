using UnityEngine;
using System.Collections;

public class MoveMent : MonoBehaviour {

	float startHeight;
	void Start(){
		startHeight = this.transform.position.y;
	}

	void FixedUpdate(){
		this.transform.Translate (.25f,0f,0f);
		if (this.transform.position.y > startHeight) {
			this.transform.Translate (0f,-.1f,0f);
		}
		if (Input.GetKey("w")&& this.yFromCamera()<5f&&startHeight==this.transform.position.y){
			this.transform.Translate (0f,2f,0f);
		}
		else if (Input.GetKey("s")&& this.yFromCamera()>-3f){
			this.transform.Translate (0f,-.2f,0f);
		}
		if (Input.GetKey ("d") && this.xFromCamera () < 7.5f) {
			this.transform.Translate (.2f, 0f, 0f);
		}
		else if (Input.GetKey("a")&& this.xFromCamera()>-7.5f){
			this.transform.Translate (-.2f,0f,0f);
		}
	}

	private float xFromCamera(){
		return ((this.transform.position.x)-(Camera.main.transform.position.x));
	}

	private float yFromCamera(){
		return ((this.transform.position.y)-(Camera.main.transform.position.y));
	}
}