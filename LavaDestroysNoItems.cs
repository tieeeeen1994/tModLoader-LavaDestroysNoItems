using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LavaDestroysNoItems
{
	public class LavaDestroysNoItems : Mod
	{
        public override void Load()
        {
            On_Item.CheckLavaDeath += On_Item_CheckLavaDeath;
        }

        public override void Unload()
        {
            On_Item.CheckLavaDeath -= On_Item_CheckLavaDeath;
        }

        private void On_Item_CheckLavaDeath(On_Item.orig_CheckLavaDeath orig, Item self, int i)
        {
            Config modConfig = ModContent.GetInstance<Config>();
            if (modConfig.LavaDestroyables.Exists(definition => definition.Type == self.type))
            {
                orig(self, i); // This still doesn't destroy items that have higher rarity than white.
                if (self.active)
                {
                    self.active = false;
                    self.type = ItemID.None;
                    self.stack = 0;
                    if (Main.netMode != NetmodeID.SinglePlayer)
                    {
                        NetMessage.SendData(MessageID.SyncItem, -1, -1, null, i);
                    }
                }
            }
        }
    }
}
