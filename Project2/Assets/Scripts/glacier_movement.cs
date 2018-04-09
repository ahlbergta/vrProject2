using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glacier_movement : MonoBehaviour {

    public GameObject valueTracker;
    private Values values;

    // Use this for initialization
    void Start () {
		values = valueTracker.GetComponent<Values>();
        
    }
	
	// Update is called once per frame
	void Update () {
        values.temperature = 100; //example temperature

        if(transform.position.y >= -80 && transform.position.y <= 80)
        {
            transform.Translate(0, -values.temperature * Time.deltaTime * 0.3f, 0);

        }
        //Debug.Log(transform.position);
        //transform.position = new Vector3(300, -values.temperature ,900);

	}
}
