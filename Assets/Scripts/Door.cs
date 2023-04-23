using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Cauldron cauldron;
    public bool isUnlocked = false;
    public bool isOpen = false;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onClick() {
        if(isUnlocked) {
            isOpen = true;
            
        }
        // else do nothing
    }
}
