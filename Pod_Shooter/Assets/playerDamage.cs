using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : Damagable
{
    PlayerLife playerLife;
	// Use this for initialization
	void Start () {
        playerLife = GetComponent<PlayerLife>();
	}

    public override void DealDamage(int damage, Collision collision)
    {
        playerLife.TakeDamage(damage, collision);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
