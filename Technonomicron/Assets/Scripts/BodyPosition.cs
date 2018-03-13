using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPosition : MonoBehaviour {
	public Transform target;
	public Vector3 adjust;
	public bool fullRotation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.position + adjust;
		if(!fullRotation)
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, target.eulerAngles.y, transform.eulerAngles.z);
		else if (fullRotation) {
			transform.rotation = target.rotation;
		}
	}
}
