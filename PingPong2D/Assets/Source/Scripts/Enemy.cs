
using System;
using Unity.VisualScripting;

using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    private FailTrigger _failTrigger;
    private bool _side;
    public Action<Enemy> OnDestroy;


    public void Setup(bool side, FailTrigger failTrigger)
    {
        _failTrigger = failTrigger;
        _side = side;
    }

    private void Update()
    {
        if(!_side)
            transform.position += Vector3.left * _speed;
        else
            transform.position += Vector3.right * _speed;
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ball ball))
        {
            _failTrigger.OnFail?.Invoke();
        }
    }
}
