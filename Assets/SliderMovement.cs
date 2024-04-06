using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SliderMovement : MonoBehaviour
{
    public Slider HungerSlider;
    public static float Hunger;
    float maxHunger = 100f;

    private void Start()
    {
        Hunger = maxHunger;
    }

    private void Update()
    {

        Debug.Log(Hunger);
        HungerSlider.value = Hunger;

        if (Hunger >= 0)
        {
            Hunger -= 5 * Time.deltaTime;
        }

        if (Hunger <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
