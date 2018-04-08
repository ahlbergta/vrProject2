using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exampleScript : MonoBehaviour {

    public GameObject valueTracker;
    private Values values;

	// Use this for initialization
	void Start () {
        values = valueTracker.GetComponent<Values>();
	}
	
	// Update is called once per frame
	void Update () {

        // Use this to set values
        values.temperature = 100.0f;
	}
}
