using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public Cauldron cauldron;
    //public Light cauldronLight;
    public Door door1;
    public Door door2;
    public Door door3;
    public Door door4;
    public Door door5;
    public Door door6;
    public Door door7;
    public Door door8;
    private TimeTracker titr;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        cauldron.GetComponent<Renderer>().material.color = new Color(153, 153, 153, 255);
        door1.unlock();
    }

    // Update is called once per frame
    void Update()
    {
        if(door8.open()) {
            if(count < 8){
                count++;
                titr.ReachedCheckpoint();
                titr.ExportTimeData();
            }
            // Open Completion UI
        }
        else if(door7.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(178, 114, 152, 255);
            door8.unlock();
            if(count < 7){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        else if(door6.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(199, 100, 38, 255);
            door7.unlock();
            if(count < 6){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        else if(door5.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(46, 114, 173, 255);
            door6.unlock();
            if(count < 5){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        else if(door4.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(238, 227, 97, 255);
            door5.unlock();
            if(count < 4){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        
        else if(door3.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(69, 155, 118, 255);
            door4.unlock();
            if(count < 3){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        else if(door2.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(92, 151, 193, 255);
            door3.unlock();
            if(count < 2){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        else if(door1.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(218, 159, 55, 255);
            door2.unlock();
            if(count < 1){
                count++;
                titr.ReachedCheckpoint();
            }
        }
    }
}
