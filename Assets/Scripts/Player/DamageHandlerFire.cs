using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerFire : DamageHandler {

    // Use this for initialization
    void OnTriggerEnter2D()
    {
        {
                health--;
        }
    }
}
