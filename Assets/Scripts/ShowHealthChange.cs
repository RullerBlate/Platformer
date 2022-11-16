using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHealthChange : MonoBehaviour
{
    private int _increasingSpeed = 10;
    public ChangeHealth slider;
    public Slider _health;
    private float _HealthTarget;

    void Update()
    {
        _health.value = Mathf.MoveTowards(_health.value, slider._healthTarget, _increasingSpeed * Time.deltaTime);
    }
}
