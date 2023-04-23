using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public GameObject cauldron;
    public Door door1;

    // Start is called before the first frame update
    void Start()
    {
        cauldron.GetComponent<Renderer>().material.color = new Color(77, 77, 77, 100);
        door1.isUnlocked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(door1.isOpen) {
            
        }
    }
}
