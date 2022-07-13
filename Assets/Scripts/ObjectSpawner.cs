using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public void SpawnBall()
    {
        Instantiate (Resources.Load ("Ball") as GameObject);
    }
     public void SpawnPlatform()
    {
        Instantiate (Resources.Load ("Platform") as GameObject);
    }
     
}
