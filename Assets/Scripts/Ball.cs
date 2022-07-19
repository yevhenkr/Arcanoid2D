using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector2 vectorSpeed;
    public event Action OnBollCollider;
    void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(vectorSpeed.x,vectorSpeed.y);
    }
    void OnCollisionEnter2D(Collision2D collider) {
        if (collider.gameObject.TryGetComponent(out Block block))
        {
            OnBollCollider?.Invoke();
        }
     
    }
}
