using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool _isGoingRight = true;

    private void Update()
    {
        if (_isGoingRight)
        transform.Translate(1 * Time.deltaTime, 0, 0);
        else
        transform.Translate(-1 * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("RightWall"))
            _isGoingRight = false;

        if (collision.gameObject.layer == LayerMask.NameToLayer("LeftWall"))
            _isGoingRight = true;
    }
}
