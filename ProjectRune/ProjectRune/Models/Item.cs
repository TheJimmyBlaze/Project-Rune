using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRune.Models
{
    public class Item
    {
        public string NaturalID { get; }
        public string Image { get => string.Format("{0}.png", NaturalID); }
        public string DisplayName { get => CalulateDisplayName(NaturalID); }

        private string CalulateDisplayName(string naturalID)
        {
            string displayName = string.Empty;

            string[] words = naturalID.Split('_');
            foreach(string word in words)
            {
                string casedWord = string.Format("{0}{1}", word.Substring(0, 1).ToUpper(), word.Substring(1));
                displayName = string.Format("{0} {1}", displayName, casedWord);
            }

            return displayName;
        }

        public Item(string naturalID)
        {
            NaturalID = naturalID;
        }
    }
}
