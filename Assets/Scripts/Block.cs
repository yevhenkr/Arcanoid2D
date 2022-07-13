using System;
using UnityEngine;

public class Block : MonoBehaviour
{
    public event Action OnDestroy;
    void OnCollisionEnter2D(Collision2D col) {
        OnDestroy?.Invoke();
        Destroy(this.gameObject);
    }
}
