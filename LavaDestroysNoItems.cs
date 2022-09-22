using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LavaDestroysNoItems
{
	public class LavaDestroysNoItems : Mod
	{
        public class AllItems : GlobalItem
        {
            public override bool? CanBurnInLava(Item item)
            {
                return item.type == ItemID.GuideVoodooDoll;
            }
        }
    }
}