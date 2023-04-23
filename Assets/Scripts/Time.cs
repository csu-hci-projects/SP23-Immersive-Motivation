using System.Collections.Generic;
using UnityEngine;
 
public class TimeTracker : MonoBehaviour {
 
    public static List <long> CheckpointTimes = new List <long>;
    public static long TimeCnt = 0;
    public bool Checkpoint = false;
    private int i = 0;
 
 
    void Update () {
        TimeCnt += Time.deltaTime;
        if(Checkpoint == true){
          CheckpointTimes[i++] = TimeCnt;
          Checkpoint = false;
        }
 
 
    }
}
