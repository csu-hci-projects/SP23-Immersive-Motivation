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

    // Start is called before the first frame update
    void Start()
    {
        cauldron.GetComponent<Renderer>().material.color = new Color(153, 153, 153, 255);
        door1.unlock();
    }

    // Update is called once per frame
    void Update()
    {
        if(door1.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(218, 159, 55, 255);
            door2.unlock();
        }
        if(door2.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(92, 151, 193, 255);
            door3.unlock();
        }
        if(door3.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(69, 155, 118, 255);
            door4.unlock();
        }
        if(door4.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(238, 227, 97, 255);
            door5.unlock();
        }
        if(door5.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(46, 114, 173, 255);
            door6.unlock();
        }
        if(door6.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(199, 100, 38, 255);
            door7.unlock();
        }
        if(door7.open()) {
            cauldron.GetComponent<Renderer>().material.color = new Color(178, 114, 152, 255);
            door8.unlock();
        }
        if(door8.open()) {
            // Open Completion UI
        }
    }
}
