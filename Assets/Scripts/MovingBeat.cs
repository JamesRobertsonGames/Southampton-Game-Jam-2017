using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBeat : MonoBehaviour {

    // Game Object is itself

    [Range(0,500)]
    public float RateOfTravel;

    float timeofdeath;

    public Vector3 StartPosition;

    // Just in case the middle changes from 0,0
    public GameObject Middle;
    

	// Use this for initialization
	void Start () {
        transform.position = StartPosition;
        transform.LookAt(Middle.transform);
	}

    void OnTriggerEnter(Collider other)
    {
        print(timeofdeath);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void FixedUpdate () {
        float step = RateOfTravel * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Middle.transform.position, step);

        timeofdeath += Time.deltaTime;
    }
}
