using System.ComponentModel;
using System.Diagnostics;

namespace ProjectRune.Models
{
    public class ItemStack
    {
        public Item Item { get; }
        public int Count { get; set; } = 1;

        public ItemStack(Item item, int count)
        {
            Item = item;
            Count = count;
        }
    }
}
