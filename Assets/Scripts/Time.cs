using System.Collections.Generic;
using UnityEngine;
using System.IO;
 
public class TimeTracker : MonoBehaviour {
 
    public static List <long> CheckpointTimes = new List <long>;
    public static long TimeCnt = 0;
    public bool Checkpoint = false;
    private int i = 0;
 
 
    void Update () {
        TimeCnt += Time.deltaTime;
        if(Checkpoint == true){
          if(i==0){
           CheckpointTimes[i++] = Time.unscaledTime;
          }
         else{
           CheckpointTimes[i++] = Time.unscaledTime - CheckpointTimes[i-1];
         }
          Checkpoint = false;
        }
 
 
    }
}
