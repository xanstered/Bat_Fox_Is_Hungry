using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerPickup : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SliderMovement.Hunger += 50f;
                Destroy(gameObject);

            }
        }
    }
    
}
