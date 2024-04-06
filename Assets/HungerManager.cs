using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HungerManager : MonoBehaviour
{
    [Header("Hunger")]
    [SerializeField] private float _maxHunger = 100f;
    [SerializeField] private float _hungerDeplationRate = 2f;
    private float _currentHunger;
    public float HungerPercent => _currentHunger / _maxHunger;

    public static UnityAction OnPlayerDied;



    private void Start()
    {
        _currentHunger = _maxHunger;
    }

    private void Update()
    {
        _currentHunger -= _hungerDeplationRate * Time.deltaTime;

        if (_currentHunger <= 0)
        {
            _currentHunger = 0;
        }
    }
    public void ReplenishHunger(float hungerAmount)
    {
        _currentHunger += hungerAmount;

        if (_currentHunger > _maxHunger) _currentHunger = _maxHunger;
    }
    public void AddHunger(float _value)
    {
        _currentHunger = Mathf.Clamp(_currentHunger + _value, 0, _maxHunger);
    }
}
