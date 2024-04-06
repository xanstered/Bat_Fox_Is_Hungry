using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodCollision : MonoBehaviour
{
    public Slider slider; // Referencja do slidera

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food")) // Sprawdzenie, czy dosz�o do kolizji z jedzeniem
        {
            slider.value += 1; // Zwi�kszenie warto�ci slidera o 1 po zderzeniu z jedzeniem
            Destroy(other.gameObject); // Zniszczenie obiektu jedzenia
        }
    }
}
