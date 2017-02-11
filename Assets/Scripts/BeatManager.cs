using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour {

    public List<MovingBeat> BeatMap = new List<MovingBeat>();

    // Ignore that stupid warning int he edit it all works fine
    public MovingBeat TempBeat;
    
    // This will change per song
    public TextAsset textFile;

    public bool FirstTime = true;

    [Range(0,254)]
    public int threshold;

    int itterationCount = 1;

    [Range(0, 100)]
    public float divisionOfTimeSplit = 1;

    public List<float> Timings = new List<float>();

    // Use this for initialization
    void Start ()
    {
        string text = textFile.text;  //this is the content as string

        AddtoIntList(text);
        TempBeat.Middle = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(SpawnLevel());

        // print(Timings[0]);
    }

    public void AddtoIntList(string str)
    {
        foreach (var s in str.Split('\n'))
        {
            if (string.IsNullOrEmpty(s))
                return;

            string milisecond = s.Split(',')[0];
            string velocity = s.Split(',')[1];

            int velocityInt;
            int.TryParse(velocity, out velocityInt);
            if (velocityInt < threshold)
            {
                continue;
            }

            int num;
            if (int.TryParse(milisecond, out num))
            {
                Timings.Add(num);
            }

        }

        if (string.IsNullOrEmpty(str))
            return;

        return;
    }

    IEnumerator SpawnLevel()
    {
        // Can't find the size of tarray at the moment
        for (int i = 0; i < Timings.Count; i++)
        {
            // We work on the Z and X axis
            if (FirstTime)
            {
                TempBeat.StartPosition = new Vector3(TempBeat.Middle.transform.position.x + (Timings[i] / divisionOfTimeSplit),
                                     TempBeat.Middle.transform.position.y,
                                     TempBeat.Middle.transform.position.z);

                FirstTime = false;
            }
            else
            {
                TempBeat.StartPosition = new Vector3(TempBeat.Middle.transform.position.x + (Timings[i] / divisionOfTimeSplit) - (0.8584f * itterationCount),
                                     TempBeat.Middle.transform.position.y,
                                     TempBeat.Middle.transform.position.z);
                itterationCount += 1;
            }

            BeatMap.Add(Instantiate(TempBeat));
        }

        yield return null;
    }

    // Update is called once per frame
    void Update ()
    {
        
	}
}
