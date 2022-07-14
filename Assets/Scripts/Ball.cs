using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector2 vectorSpeed;
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(vectorSpeed.x,vectorSpeed.y);
    }
    void OnCollisionEnter2D(Collision2D col) {
     
    }
}
