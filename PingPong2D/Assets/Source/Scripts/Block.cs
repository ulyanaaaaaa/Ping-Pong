using System;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Action<Block> OnDestroy;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ball ball))
        {
            OnDestroy?.Invoke(this);
            Destroy(gameObject);
        }
    }
}
