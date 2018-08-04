using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Animator anim;
    bool attack;
    Vector3 touchPoint = new Vector3();
    Vector3 touchPos;
    Camera cam = Camera.main;

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                cam.ViewportToWorldPoint(touchPos);
            }
        }
        
	}
}
