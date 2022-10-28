using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Controls : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _speed = 3f;
    private bool _inAir;
    private bool _isGrounded;
    private string _IsWalking = "IsWalking";
    private Animator _animator;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        _rigidbody.velocity = new Vector2(horizontal * _speed, _rigidbody.velocity.y);

        if (horizontal != 0 && _inAir == false)
        {
            _animator.SetBool(_IsWalking, true);
        }
        else
            _animator.SetBool(_IsWalking, false);

        if (Input.GetKey(KeyCode.Space) && !_inAir)
        {
            _inAir = true;
            _rigidbody.AddForce(new Vector2(0, 350));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            _inAir = false;

        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            Destroy(gameObject);

            if (collision.gameObject.layer == LayerMask.NameToLayer("Coin"))
            Destroy(collision.gameObject);
    }
}
