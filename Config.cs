using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader.Config;

namespace LavaDestroysNoItems
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public List<ItemDefinition> LavaDestroyables;

        public Config()
        {
            LavaDestroyables = [new(ItemID.GuideVoodooDoll)];
        }
    }
}
