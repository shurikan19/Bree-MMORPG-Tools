// =======================================================================================
// Created and maintained by Boba
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............:  
  
// * Leave a star on my Github Repo.....: https://github.com/breehuynh/Bree-mmorpg-tools
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public partial class Player
{
    public void TakeAllLootItem()
    {
        CmdTakeLootGold();
        var items = target.inventory.Where(item => item.amount > 0).ToList();
        for (int i = 0; i < items.Count; ++i)
        {
            int itemIndex = target.inventory.FindIndex(item => item.amount > 0 && item.item.name == items[i].item.name);
            CmdTakeLootItem(itemIndex);
        }
    }
}
