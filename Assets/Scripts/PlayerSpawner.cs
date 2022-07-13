using UnityEngine;

public class PlayerSpawner : MonoBehaviour
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
