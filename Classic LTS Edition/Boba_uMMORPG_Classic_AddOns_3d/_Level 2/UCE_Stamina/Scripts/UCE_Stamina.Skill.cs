// =======================================================================================
// Created and maintained by Boba
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............:  
  
// * Leave a star on my Github Repo.....: https://github.com/breehuynh/Bree-mmorpg-tools
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
public partial struct Skill
{

#if _iMMOSTAMINA
    public int staminaCosts => data.staminaCosts.Get(level);
#endif

}
