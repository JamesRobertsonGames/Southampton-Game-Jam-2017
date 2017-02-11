using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour {

    public List<MovingBeat> BeatMap = new List<MovingBeat>();
    public MovingBeat TempBeat = new MovingBeat();
    public TextAsset textFile;     // drop your file here in inspector

    // May inherit this from the other class in Moving Beat. Maybe even the prefab
    [Range(0, 100)]
    public float RateOfTravel = 1;

    public static List<int> Timings = new List<int>();

    int testingbuffer;

    // Use this for initialization
    void Start ()
    { 
        string text = textFile.text;  //this is the content as string
        AddtoIntList(text);
        SpawnLevel();

        // print(Timings[0]);
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
        for (int i = 0; i < Timings.Count; i++)
        {
            // We work on the Z and X axis
            TempBeat.StartPosition = new Vector3(TempBeat.Middle.transform.position.x + Timings[i], 
                                                 TempBeat.Middle.transform.position.y, 
                                                 TempBeat.Middle.transform.position.z);
            BeatMap.Add(Instantiate(TempBeat));
        }
        
        
    }

    // Update is called once per frame
    void Update ()
    {
        
	}
}
