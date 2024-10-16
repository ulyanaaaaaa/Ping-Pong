using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float _speed = 7f;
    private Vector2 _direction;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _direction = new Vector2(Random.Range(0f, 1f), Random.Range(-1f, 1f));
        _direction.Normalize(); 
    }

    private void Update()
    {
        Vector2 velocity = _direction * _speed;
        
        if (velocity.magnitude > _speed)
        {
            velocity = velocity.normalized * _speed;
        }

        _rigidbody2D.velocity = velocity;
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

        if (collision.gameObject.TryGetComponent(out DefenceX defence))
        {
            _direction.x = -_direction.x;
        }

        if (collision.gameObject.TryGetComponent(out DefenceY defence1))
        {
            _direction.y = -_direction.y;
        }
        
        _direction.Normalize();
    }
}

