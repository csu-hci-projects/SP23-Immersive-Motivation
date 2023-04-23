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
        cauldron.GetComponent<Renderer>().material.color = new Color(77, 77, 77, 255);
        door1.isUnlocked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(door1.isOpen) {
            //cauldron.GetComponent<Renderer>().material.color = new Color(77, 77, 77, 255);
            door2.isUnlocked = true;
        }
        if(door2.isOpen) {

        }
        if(door3.isOpen) {

        }
        if(door4.isOpen) {

        }
        if(door5.isOpen) {

        }
    }
}
