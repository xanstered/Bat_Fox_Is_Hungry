using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : MonoBehaviour
{
    [SerializeField] private float startingHunger;
    public float currentHunger { get; private set; }

    private void Awake()
    {
        currentHunger = startingHunger;
    }
    public void AddHunger(float _value)
    {
        currentHunger = Mathf.Clamp(currentHunger + _value, 0,  startingHunger);
    }

    
   
}
