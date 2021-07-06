using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRune.Models.ItemModels
{
    public class ItemCategory
    {
        public readonly string Value;

        public static ItemCategory RawResource { get => new ItemCategory("Raw Resource"); }
        public static ItemCategory RefinedResource { get => new ItemCategory("Refined Resource"); }
        public static ItemCategory Tool { get => new ItemCategory("Tool"); }

        public ItemCategory(string value)
        {
            Value = value;
        }
    }
}
