using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Bullet : NetworkBehaviour
{

    Rigidbody rigidBody;
    [SerializeField]float DestroyBulletAfterCollisionTime = 5f;
    [SerializeField] float maxLifeTime = 120f;
    [SerializeField] float bulletForce = 1500;
    [SerializeField] int bulletdamage = 25;
    // Use this for initialization

    void Start() {
        rigidBody = GetComponent<Rigidbody>();
        Vector3 ajustedMovement = transform.TransformDirection(Vector3.forward); /* Bouge selon TON axe des X */
        rigidBody.AddForce(ajustedMovement * bulletForce);
        Invoke("DetroyBullet", maxLifeTime);
    }

  

    private void OnCollisionEnter(Collision collision) {
       // Damagable damagable = collision
        if (isServer)
        {
            Damagable damagable = collision.gameObject.GetComponent<Damagable>();
            if (damagable != null)
            {
                damagable.DealDamage(bulletdamage, collision);
                Destroy(gameObject);
            }
        }
        Invoke("DetroyBullet", DestroyBulletAfterCollisionTime);
    }

    private void DetroyBullet() {
        Destroy(gameObject);
    }
}
