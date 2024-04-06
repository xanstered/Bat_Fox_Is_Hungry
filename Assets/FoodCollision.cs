using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodCollision : MonoBehaviour
{
    public Slider slider; // Referencja do slidera

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food")) // Sprawdzenie, czy dosz³o do kolizji z jedzeniem
        {
            slider.value += 1; // Zwiêkszenie wartoœci slidera o 1 po zderzeniu z jedzeniem
            Destroy(other.gameObject); // Zniszczenie obiektu jedzenia
        }
    }
}
