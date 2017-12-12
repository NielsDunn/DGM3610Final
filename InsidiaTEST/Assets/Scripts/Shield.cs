using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : pickupSetter {

	private int shieldHealth = 100;

	public override void OnStart ()
	{
		
	}

    public override void OnTriggerEnter(Collider other)
    {
    	base.OnTriggerEnter(other);

    	transform.GetChild(0).gameObject.SetActive(true);

    	//playerStats shieldHealth = whatevs
    }
}
