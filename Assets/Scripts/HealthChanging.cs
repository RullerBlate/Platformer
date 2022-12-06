using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthChanging : MonoBehaviour
{
    [SerializeField] protected Slider _health;
    [SerializeField] protected float _healthTarget;

    public void IncreaseHP()
    {
        if (_health.value + 1 <= _health.maxValue)
            _healthTarget = _health.value + 1;
        StartCoroutine("ChangeHealth");
    }

    public void LowHP()
    {
        if (_health.value - 1 >= _health.minValue)
            _healthTarget = _health.value - 1;
        StartCoroutine("ChangeHealth");
    }

    public IEnumerator ChangeHealth()
    {
        while (_health.value != _healthTarget)
        {
            _health.value = Mathf.MoveTowards(_health.value, _healthTarget, 2f * Time.deltaTime);
            yield return null;
        }
    }
}
