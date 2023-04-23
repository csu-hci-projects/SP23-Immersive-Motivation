using System.Collections.Generic;
using UnityEngine;
using System.IO;
 
public class TimeTracker : MonoBehaviour {
 
    public static List <long> CheckpointTimes = new List <long>;
    public static long TimeCnt = 0;
    private int i = 0;
 
 
    void Update () {
        TimeCnt += Time.deltaTime;
    }
    public void ReachedCheckpoint(){
       if(i==0){
           CheckpointTimes[i++] = Time.unscaledTime;
       }
       else{
           CheckpointTimes[i++] = Time.unscaledTime - CheckpointTimes[i-1];
       }
    }
    public void ExportTimeData(){
      StreamWriter writer = new StreamWriter(path, true);
      for each long t in CheckpointTimes{
        string path = "Assets/CheckpointTimes.txt";
        //Write some text to the test.txt file
        
        writer.WriteLine("\nTime: ",TimeTracker.CheckpointTimes[i++]);
        
      }
     writer.Close();
        //Re-import the file to update the reference in the editor
     AssetDatabase.ImportAsset(path); 
     TextAsset asset = Resources.Load("test");
        //Print the text from the file
     Debug.Log(asset.text);
    }
}
