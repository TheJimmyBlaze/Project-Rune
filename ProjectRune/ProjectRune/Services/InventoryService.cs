using ProjectRune.Models;
using ProjectRune.Models.ItemModels;
using ProjectRune.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace ProjectRune.Services
{
    public class InventoryService
    {
        private ModifiableObservableCollection<ItemStack> contents;
        public ModifiableObservableCollection<ItemStack> Contents
        {
            get
            {
                if (contents == null)
                    contents = new ModifiableObservableCollection<ItemStack>();
                return contents;
            }
        }

        private readonly RandomService random = DependencyService.Get<RandomService>();

        public void AddItem(Item item, int count = 1)
        {
            ItemStack stack = Contents.SingleOrDefault(existing => existing.Item == item);
            if (stack == null)
            {
                stack = new ItemStack(item, count);
                Contents.Add(stack);
            }
            else
            {
                stack.Add(count);
            }
        }

        public void GenerateTestItem()
        {
            List<Item> candidates = new List<Item>()
            {
                ItemDictionary.StoneChunk,
                ItemDictionary.TinOre,
                ItemDictionary.CopperOre,
                ItemDictionary.IronOre,
                ItemDictionary.PineLog,
                ItemDictionary.BronzeIngot,
                ItemDictionary.IronIngot,
                ItemDictionary.SteelIngot,
                ItemDictionary.ToolHandle,
                ItemDictionary.StoneAxe,
                ItemDictionary.StonePick,
                ItemDictionary.BronzeAxe,
                ItemDictionary.BronzePick
            };

            Item chosen = candidates[random.Next(candidates.Count)];

            AddItem(chosen);
        }
    }
}
