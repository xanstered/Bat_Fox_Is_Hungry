using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    [SerializeField] private Hunger playerHunger;
    [SerializeField] private Image totalHungerBar;
    [SerializeField] private Image currentHungerBar;


    private void Start()
    {
        totalHungerBar.fillAmount = playerHunger.currentHunger / 10;
    }
    private void Update()
    {
        currentHungerBar.fillAmount = playerHunger.currentHunger / 10;
    }
}
