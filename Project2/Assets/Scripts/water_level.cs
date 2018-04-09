using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_level : MonoBehaviour {

    public GameObject valueTracker;
    private Values values;

	// Use this for initialization
	void Start () {
		values = valueTracker.GetComponent<Values>();
    }
	
	// Update is called once per frame
	void Update () {
        values.temperature = 40;    //example temperature
        
        if (transform.position.y >= 0 && transform.position.y <=40)
        {
            transform.Translate(0, values.temperature * Time.deltaTime * 0.3f , 0);
            //transform.position = new Vector3(0,transform.position.y + values.temperature,0);
            //Debug.Log(values.waterLevel);
            
        }

        values.waterLevel = transform.position.y;
        
	}
}
