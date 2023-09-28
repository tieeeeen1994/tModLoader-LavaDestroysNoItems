using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LavaDestroysNoItems
{
	public class LavaDestroysNoItems : Mod
	{
        public class AllItems : GlobalItem
        {
            public override void SetStaticDefaults()
            {
                On_Item.CheckLavaDeath += On_Item_CheckLavaDeath;
            }

            private void On_Item_CheckLavaDeath(On_Item.orig_CheckLavaDeath orig, Item self, int i)
            {
                if (self.rare == ItemRarityID.White && self.type != ItemID.GuideVoodooDoll )
                {
                    if (Main.netMode != NetmodeID.SinglePlayer) NetMessage.SendData(MessageID.SyncItem, -1, -1, null, i);
                }
                else orig(self, i);
            }
        }
    }
}