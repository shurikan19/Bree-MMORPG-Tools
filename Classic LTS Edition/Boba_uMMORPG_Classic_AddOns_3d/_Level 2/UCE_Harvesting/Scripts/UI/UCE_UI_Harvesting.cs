// =======================================================================================
// Created and maintained by Boba
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............:  
  
// * Leave a star on my Github Repo.....: https://github.com/breehuynh/Bree-mmorpg-tools
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
using UnityEngine;

#if _iMMOHARVESTING

// ===================================================================================
// UCE UI HARVESTING
// ===================================================================================
public partial class UCE_UI_Harvesting : MonoBehaviour
{
    public GameObject panel;
    public Transform content;
    public UCE_UI_HarvestingSlot slotPrefab;
    public KeyCode hotKey = KeyCode.H;

    // -----------------------------------------------------------------------------------
    // Update
    // -----------------------------------------------------------------------------------
    private void Update()
    {
        Player player = Player.localPlayer;
        if (!player) return;

        if (Input.GetKeyDown(hotKey) && !UIUtils.AnyInputActive())
            panel.SetActive(!panel.activeSelf);

        if (panel.activeSelf && player.UCE_Professions.Count > 0)
        {
            UIUtils.BalancePrefabs(slotPrefab.gameObject, player.UCE_Professions.Count, content);

            for (int i = 0; i < content.childCount; i++)
            {
                content.GetChild(i).GetComponent<UCE_UI_HarvestingSlot>().Show(player.UCE_Professions[i]);
            }
        }
    }

    // -----------------------------------------------------------------------------------
}

#endif
