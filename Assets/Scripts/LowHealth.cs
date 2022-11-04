using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LowHealth : MonoBehaviour
{
    public Slider _health;
    static public float _healthTarget;
    public bool _isLowing = false;
    private int _lowingSpeed = 10;

    public void Update()
    {
        if (_isLowing == true && _health.value != _healthTarget)
            _health.value = Mathf.MoveTowards(_health.value, _healthTarget, _lowingSpeed * Time.deltaTime);
        else
            _isLowing = false;
    }

    public void LowHP()
    {
        _isLowing = true;
        _healthTarget = _health.value - 1;
    }
}
