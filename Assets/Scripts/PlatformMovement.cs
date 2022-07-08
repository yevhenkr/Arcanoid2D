using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
   
   [SerializeField] private float speed = 3f;
   private void FixedUpdate()
   {
      if (Input.GetKey("right"))
      {
         float move = Input.GetAxis("Horizontal");
         transform.position = Vector3.MoveTowards(transform.position, transform.position + (new Vector3(move, 0f, 0f)),
            speed * Time.deltaTime);
      }if (Input.GetKey("left"))
      {
         float move = Input.GetAxis("Horizontal");
         transform.position = Vector3.MoveTowards(transform.position, transform.position - (new Vector3(-move, 0f, 0f)),
            speed * Time.deltaTime);
      }
   }

   public void PlatformMove(float move)
   {
      transform.position = Vector3.MoveTowards(transform.position, transform.position + (new Vector3(move, 0f, 0f)),
         speed * Time.deltaTime);
   }
}
