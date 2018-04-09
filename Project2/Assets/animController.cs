using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

    public GameObject valueTracker;
    public Animator anim;

    private Values values;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        values = valueTracker.GetComponent<Values>();
    }
	
	// Update is called once per frame
	void Update () {
		
        if(values.waterLevel > 35)
        {
            anim.Play("shark");
        }

	}
}
