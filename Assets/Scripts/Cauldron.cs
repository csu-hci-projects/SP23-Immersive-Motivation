using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public Cauldron cauldron;
    public GameObject fluid;
    //public Light cauldronLight;
    public Door door1;
    public Door door2;
    public Door door3;
    public Door door4;
    public Door door5;
    public Door door6;
    public Door door7;
    public Door door8;
    private TimeTracker titr = new TimeTracker();
    private int count = 0;

    public GameObject survey;
    public GameObject playerCam;
    public GameObject staticCam;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        fluid.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
        door1.unlock();
    }

    // Update is called once per frame
    void Update()
    {
        if(door8.open()) {
            survey.SetActive(true);
            if (count < 8){
                count++;
                titr.ReachedCheckpoint();
                titr.ExportTimeData();
            }
            // Open Completion UI
            
            playerCam.SetActive(false);
            staticCam.SetActive(true);
            player.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        else if(door7.open()) {
            fluid.GetComponent<Renderer>().material.color = new Color(1f, 0.6847826f, 0.8804347f, 1f);
            door8.unlock();
            if(count < 7){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        else if(door6.open()) {
            fluid.GetComponent<Renderer>().material.color = new Color(1f, 0.5263158f, 0.2315789f, 1f);
            door7.unlock();
            if(count < 6){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        else if(door5.open()) {
            fluid.GetComponent<Renderer>().material.color = new Color(0.3333333f, 0.6547619f, 1f, 1f);
            door6.unlock();
            if(count < 5){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        else if(door4.open()) {
            fluid.GetComponent<Renderer>().material.color = new Color(1f, 0.942623f, 0.4672132f, 1f);
            door5.unlock();
            if(count < 4){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        
        else if(door3.open()) {
            fluid.GetComponent<Renderer>().material.color = new Color(0.5657895f, 1f, 0.7631579f, 1f);
            door4.unlock();
            if(count < 3){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        else if(door2.open()) {
            fluid.GetComponent<Renderer>().material.color = new Color(0.5309f, 0.7964602f, 1f, 1f);
            door3.unlock();
            if(count < 2){
                count++;
                titr.ReachedCheckpoint();
            }
        }
        else if(door1.open()) {
            fluid.GetComponent<Renderer>().material.color = new Color(1f, 0.7592593f, 0.3240741f, 1f);
            door2.unlock();
            if(count < 1){
                count++;
                titr.ReachedCheckpoint();
            }
        }
    }
}
