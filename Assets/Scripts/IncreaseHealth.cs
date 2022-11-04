using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseHealth : MonoBehaviour
{
    public Slider _health;
    static public float _healthTarget;
    public bool _isIncreasing = false;
    private int _increasingSpeed = 10;

    public void Update()
    {
        if (_isIncreasing == true && _health.value != _healthTarget)
            _health.value = Mathf.MoveTowards(_health.value, _healthTarget, _increasingSpeed * Time.deltaTime);
        else
            _isIncreasing = false;
    }

    public void IncreaseHP()
    {
        _isIncreasing = true;
        _healthTarget = _health.value + 1;
    }
}