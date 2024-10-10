using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailTrigger : MonoBehaviour
{
    public Action OnFail;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ball ball))
        {

            OnFail?.Invoke();
        }
    }
}
