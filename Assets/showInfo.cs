using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showInfo : MonoBehaviour {

	public GameObject canvas;
	public GameObject[] canvases;

	void Start(){
		canvases = GameObject.FindGameObjectsWithTag ("InfoTag"); 
		canvas = GameObject.FindGameObjectWithTag ("Canvas");
//		info = canvases [0];
		canvas.GetComponent<CanvasGroup> ().alpha = 0f;
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			canvas.GetComponent<CanvasGroup> ().alpha = 1f;
		}
	}
}
