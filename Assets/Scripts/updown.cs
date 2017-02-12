using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour {

    float TimerUpandDown;
    public float Amplitude;
    private Vector3 _startPosition;

    public bool opposite; 

    // Use this for initialization
    void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        TimerUpandDown = Time.deltaTime;
        
        if (opposite)
        {
            transform.position = _startPosition + new Vector3(0.0f, Mathf.Sin(Time.time) * Amplitude, 0.0f);
        }
        else
        {
            transform.position = _startPosition - new Vector3(0.0f, Mathf.Sin(Time.time) * Amplitude, 0.0f);
        }
        

    }
}
