﻿using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Regressus.Content.NPCs.Critters;

namespace Regressus.Items.Critters {
    public class LavaButterItem : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Lava Glowfly");
        }

        public override void SetDefaults() {
            Item.useStyle = 1;
            Item.autoReuse = true;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.width = 22;
            Item.height = 18;
            Item.noUseGraphic = true;
            Item.rare = 4;
            Item.makeNPC = (short)NPCType<LavaButterfly>();
        }
    }
}