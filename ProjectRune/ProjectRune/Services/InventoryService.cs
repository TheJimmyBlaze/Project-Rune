using ProjectRune.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;

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

        private readonly RandomService random = DependencyService.Get<RandomService>();

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

        public void GenerateTestItem()
        {
            List<Item> candidates = new List<Item>()
            {
                new Item("bronze_ingot"),
                new Item("pine_log"),
                new Item("stone_chunk"),
            };

            Random rand = random.Random;
            Item chosen = candidates[rand.Next(3)];

            AddItem(chosen);
        }
    }
}
