using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public abstract class Damagable : MonoBehaviour
{

    abstract public void DealDamage(int damage, Collision collision);
}
