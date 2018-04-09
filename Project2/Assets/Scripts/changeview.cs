using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class changeview : MonoBehaviour {

    public PostProcessingProfile normal;
    public PostProcessingProfile underwaterfx;

    private PostProcessingBehaviour camImageFx;

    // Use this for initialization
    void Start () {
        camImageFx = FindObjectOfType<PostProcessingBehaviour>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(transform.position.y > 30)
        {
            camImageFx.profile = underwaterfx;
        }
        if (transform.position.y < 30)
        {
            camImageFx.profile = normal;
        }


    }
}
