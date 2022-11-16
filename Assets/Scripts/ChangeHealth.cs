using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHealth : MonoBehaviour
{
    public Slider _health;
    public float _healthTarget;

    public void IncreaseHP()
    {
        _healthTarget = _health.value + 1;
    }

    public void LowHP()
    {
        _healthTarget = _health.value - 1;
    }
}
