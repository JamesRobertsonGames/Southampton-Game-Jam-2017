using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour {

    public GameObject Beat;
    public TextAsset textFile;     // drop your file here in inspector

    // May inherit this from the other class in Moving Beat. Maybe even the prefab
    [Range(0, 100)]
    public float RateOfTravel = 1;


    // Use this for initialization
    void Start ()
    {
        string text = textFile.text;  //this is the content as string
        int.Parse(text);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
