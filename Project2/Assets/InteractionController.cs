using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(this.GetComponent<Camera>().transform.position.x);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Transform camTransform = this.GetComponent<Camera>().transform;
            Ray ray = new Ray(camTransform.);
        }
	}
}
