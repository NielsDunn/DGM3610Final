using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class pickupSetter : MonoBehaviour {

    public int type = 1;

    public virtual void OnStart()
    {

    }

    public virtual void OnTriggerEnter(Collider other)
    {
        //PlayerPowerUpManager.pickedUp(type);
    }

}
