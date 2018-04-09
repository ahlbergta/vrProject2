using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shark : MonoBehaviour {

    public GameObject valueTracker;
    public Animation anim;

    private Values values;



	// Use this for initialization
	void Start () {
        
        values = valueTracker.GetComponent<Values>();
        anim = GetComponent<Animation>();
    }
	
	// Update is called once per frame
	void Update () {


        if(values.waterLevel > 35)
        {
            anim.Play("shark");
        }

        
        

	}
}
