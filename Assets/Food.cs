using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]

public class Food : MonoBehaviour
{
   
    [SerializeField] private float _hungerToReplenish;

    public object AddHunger { get; internal set; }

    private void Awake()
    {
        GetComponent<SphereCollider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("bat")) return;
        var HungerManager = other.gameObject.GetComponent<HungerManager>();

        if (HungerManager != null) return;
    }
}



