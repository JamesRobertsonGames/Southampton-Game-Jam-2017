using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour {

    public List<MovingBeat> BeatMap = new List<MovingBeat>();
    public TextAsset textFile;     // drop your file here in inspector

    // May inherit this from the other class in Moving Beat. Maybe even the prefab
    [Range(0, 100)]
    public float RateOfTravel = 1;

    public static List<int> Timings = new List<int>();

    bool stillNumber = true;

    int testingbuffer;



    // Use this for initialization
    void Start ()
    { 
        string text = textFile.text;  //this is the content as string
        AddtoIntList(text);

        print(Timings[0]);
    }

    public static void AddtoIntList(string str)
    {
        foreach (var s in str.Split(','))
        {
            if (string.IsNullOrEmpty(str))
                return;

            int num;
            if (int.TryParse(s, out num))
            {
                Timings.Add(num);
            }

        }

        if (string.IsNullOrEmpty(str))
            return;

        return;
    }

    void SpawnLevel()
    {
        // Can't find the size of tarray at the moment

        I
    }

    // Update is called once per frame
    void Update ()
    {
        
	}
}
