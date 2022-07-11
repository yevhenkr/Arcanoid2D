using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
   
   [SerializeField] private float speed = 8f;
   private Rigidbody2D _rb;

   private void Start()
   {
      _rb = GetComponent<Rigidbody2D>();
   }

   private void FixedUpdate()
   {
      if (Input.GetKey("right"))
      {
         float h = Input.GetAxisRaw("Horizontal");

         // Set Velocity (movement direction * speed)
         _rb.velocity = Vector2.right * h * speed;
      }if (Input.GetKey("left"))
      {
         float h = -1;Input.GetAxisRaw("Horizontal");
         // Set Velocity (movement direction * speed)
         _rb.velocity = Vector2.right * h * speed;
         //PlatformMove(Vector2.left);
      }
      if (!Input.GetKey("right")&& !Input.GetKey("left"))
      {
         float h = -1;Input.GetAxisRaw("Horizontal");
         // Set Velocity (movement direction * speed)
         _rb.velocity = Vector2.zero * h * speed;
      }
   }

   public void PlatformMove(Vector2 side)
   {
      float h = Input.GetAxisRaw("Horizontal");

      // Set Velocity (movement direction * speed)
      _rb.velocity = side * h * speed;
   }
  
}
