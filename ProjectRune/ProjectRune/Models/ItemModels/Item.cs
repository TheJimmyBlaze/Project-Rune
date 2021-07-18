using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjectRune.Models.ItemModels
{
    public class Item
    {
        public string NaturalID { get; }

        protected ItemCategory category;
        public string Category { get => category.Value; }

        public string Image { get => string.Format("{0}.png", NaturalID); }
        public string DisplayName { get => CalulateDisplayName(); }

        protected string CalulateDisplayName()
        {
            string displayName = string.Empty;

            string[] words = NaturalID.Split('_');
            foreach (string word in words)
            {
                string casedWord = string.Format("{0}{1}", word.Substring(0, 1).ToUpper(), word.Substring(1));
                displayName = string.Format("{0} {1}", displayName, casedWord);
            }

            return displayName;
        }

        public Item(string naturalID, ItemCategory category)
        {
            NaturalID = naturalID;
            this.category = category;
        }

        public bool Equals(Item item)
        {
            if (item.NaturalID == NaturalID)
                return true;
            return false;
        }

        public override bool Equals(object obj) => this.Equals(obj as Item);

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Item x, Item y)
        {
            if (x is null)
            {
                if (y is null)
                    return true;
                return false;
            }

            return x.Equals(y);
        }

        public static bool operator !=(Item x, Item y) => !(x == y);
    }
}
