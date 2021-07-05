using ProjectRune.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace ProjectRune.Services
{
    public class InventoryService
    {
        private Dictionary<string, ItemStack> contents;
        public Dictionary<string, ItemStack> Contents
        {
            get
            {
                if (contents == null)
                    contents = new Dictionary<string, ItemStack>();
                return contents;
            }
        }

        public EventHandler ContentsChanged;
        private void OnContentsChanged() => ContentsChanged?.Invoke(this, null);

        public void AddItem(Item item, int count = 1)
        {
            string id = item.NaturalID;

            if (Contents.ContainsKey(id))
            {
                ItemStack stack = contents[id];
                stack.Count += count;
            }
            else
            {
                ItemStack newStack = new ItemStack(item, count);
                Contents.Add(id, newStack);
            }

            OnContentsChanged();
        }
    }
}
