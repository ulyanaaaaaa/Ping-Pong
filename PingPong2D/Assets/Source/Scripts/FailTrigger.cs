using System;
using UnityEngine;

public class FailTrigger : MonoBehaviour
{
    public Action OnFail;
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ball ball))
        {
            OnFail?.Invoke();
        }
    }
}
