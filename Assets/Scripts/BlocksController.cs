﻿using UnityEngine;

public class BlocksController : MonoBehaviour
{
    [SerializeField]
    public GameObject blockPrefab;
    [SerializeField]
    public Vector2 mapBlocks;
    private int blocksCount;
    
    public void GenerationBlocks()
    {
        float blockWidth = blockPrefab.GetComponent<BoxCollider2D>().size.x;
        float blockHeight = blockPrefab.GetComponent<BoxCollider2D>().size.y;
        float xOffset = blockWidth + blockWidth/10;
        float yOffset = blockHeight + blockHeight/10;
         
        var yPos = blockPrefab.GetComponent<Transform>().position.y;
        for (int x = 0; x < mapBlocks.x; x++)
        {
            var xPos = blockPrefab.GetComponent<Transform>().position.x;
            for (int y = 0; y < mapBlocks.y; y++){
                Vector2 tilePosition = new Vector2(xPos, yPos);
                var block = Instantiate(blockPrefab, tilePosition, Quaternion.Euler(Vector3.zero));
                block.GetComponent<Block>().OnDestroy += DestroyObjectEvent;
                xPos += xOffset;
                blocksCount++;
            }
            yPos -= yOffset;
        }
    }
    public void DestroyObjectEvent()
    {
        blocksCount--;
        if (blocksCount == 0)
        {
            print("EndGame");
        }
    }

}
