using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBeat : MonoBehaviour {

    // Game Object is itself

    [Range(0,500)]
    public float RateOfTravel;

    float timeofdeath;

    public Vector3 StartPosition;

    float journeyLength;

    float startTime;

    // Just in case the middle changes from 0,0
    public GameObject Middle;
    

	// Use this for initialization
	void Start () {
        startTime = Time.time;
        transform.position = StartPosition;
        transform.RotateAround(Middle.transform.position, Vector3.down, Random.Range(0, 359));
        transform.LookAt(Middle.transform);

        journeyLength = Vector3.Distance(transform.position, Middle.transform.position);
    }

    void OnTriggerEnter(Collider other)
    {
        //print(timeofdeath);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void FixedUpdate () {
        float step = RateOfTravel * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Middle.transform.position, step);
        timeofdeath += Time.deltaTime;
    }
}
