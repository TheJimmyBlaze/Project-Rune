using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRune.Models.ItemModels
{
    public class ItemDictionary
    {
        public static Item StoneChunk => new Item("stone_chunk", ItemCategory.RawResource);
        public static Item CopperOre => new Item("copper_ore", ItemCategory.RawResource);
        public static Item TinOre => new Item("tin_ore", ItemCategory.RawResource);
        public static Item IronOre => new Item("iron_ore", ItemCategory.RawResource);
        public static Item PineLog => new Item("pine_log", ItemCategory.RawResource);

        public static Item BronzeIngot => new Item("bronze_ingot", ItemCategory.RefinedResource);
        public static Item IronIngot => new Item("iron_ingot", ItemCategory.RefinedResource);
        public static Item SteelIngot => new Item("steel_ingot", ItemCategory.RefinedResource);
        public static Item ToolHandle => new Item("tool_handle", ItemCategory.RefinedResource);

        public static Item StoneAxe => new Item("stone_axe", ItemCategory.Tool);
        public static Item StonePick => new Item("stone_pick", ItemCategory.Tool);
        public static Item BronzeAxe => new Item("bronze_axe", ItemCategory.Tool);
        public static Item BronzePick => new Item("bronze_pick", ItemCategory.Tool);
    }
}
