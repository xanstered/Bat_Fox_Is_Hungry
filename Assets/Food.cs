using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]

public class Food : MonoBehaviour
{
   
    [SerializeField] private float _hungerToReplenish;


    private void Awake()
    {
        GetComponent<SphereCollider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("player")) return;
        var HungerManager = other.gameObject.GetComponent<HungerManager>();

        if (HungerManager != null) return;
    }
}



