using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private float _speed = 15f;
    private Vector2 _direction;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _direction = new Vector2(Random.Range(0f,1f), Random.Range(-1f,1f));
    }

    private void Update()
    {
        _rigidbody2D.velocity = _direction * _speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Platform platform))
        {
            _direction.y = -_direction.y;
            _direction.x += Random.Range(-0.5f, 0.5f);
        }
        
        if (collision.gameObject.TryGetComponent(out Block block))
        {
            _direction.y = -_direction.y;
            _direction.x += Random.Range(-0.5f, 0.5f);
        }

        if (collision.gameObject.TryGetComponent(out Defence defence))
        {
            _direction.x = -_direction.x;
        }
    }
}
