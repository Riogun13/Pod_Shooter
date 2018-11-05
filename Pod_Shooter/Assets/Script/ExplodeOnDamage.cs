using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnDamage : Damagable {
    
    [SerializeField]float ExplosionRadius = 5;
    [SerializeField] float ExplositionDamage = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void DealDamage(int Damage, Collision collision) {
        Explode();
    }

    private void Explode() {

        Destroy(gameObject);
    }
}
