using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpandDown : MonoBehaviour {

    float TimerUpandDown;
    public float Amplitude;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        TimerUpandDown = Time.deltaTime;

        transform.position = new Vector3(transform.position.x, (Mathf.Sin(TimerUpandDown) * Amplitude), transform.position.z);
		
	}
}
