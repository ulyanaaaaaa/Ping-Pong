using System;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    [field: SerializeField] private List<Block> Blocks = new List<Block>();
    public Action OnWin;

    private void Awake()
    {
        foreach (Block block in Blocks)
        {
            block.OnDestroy += DeleteBlock;
        }
    }

    private void DeleteBlock(Block block)
    {
        Blocks.Remove(block);
        
        if (Blocks.Count == 0)
            OnWin?.Invoke();
    }
}
