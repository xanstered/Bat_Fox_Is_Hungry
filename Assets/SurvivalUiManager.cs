using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurvivalUiManager : MonoBehaviour
{
    [SerializeField] HungerManager _HungerManager;

    [SerializeField] private Slider _hungry;
    public float Hunger;

    private void Update()
    {
        _hungry.value = Hunger;
        Hunger -= 1f * Time.deltaTime;
    }

}
