using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject tilePrefab;
    [SerializeField]
    public Transform firstBlockPos;
    [SerializeField]
    public Vector2 mapSize;
    
    public void SpawnBall()
    {
        Instantiate (Resources.Load ("Ball") as GameObject);
    }
     public void SpawnPlatform()
    {
        Instantiate (Resources.Load ("Platform") as GameObject);
    }
    
     public void GenerationMap()
     {
         float blockWidth = tilePrefab.GetComponent<BoxCollider2D>().size.x;
         float blockHeight = tilePrefab.GetComponent<BoxCollider2D>().size.y;
         float xOffset = blockWidth + blockWidth/10;
         float yOffset = blockHeight + blockHeight/10;
         
         var yPos = firstBlockPos.position.y;
         for (int x = 0; x < mapSize.x; x++)
         {
             var xPos = firstBlockPos.position.x;
             for (int y = 0; y < mapSize.y; y++){
                 Vector2 tilePosition = new Vector2(xPos, yPos);
                 Instantiate(tilePrefab, tilePosition, Quaternion.Euler(Vector3.zero));
                 xPos += xOffset;
             }
             yPos -= yOffset;
         }
     }
}
