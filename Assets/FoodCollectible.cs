using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FoodCollectible : MonoBehaviour
{
    [SerializeField] private float hungerValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bat")
        {
              collision.GetComponent<Hunger>().AddHunger(hungerValue);
            gameObject.SetActive(false);
        }
    }
}
 