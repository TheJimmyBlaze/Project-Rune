using ProjectRune.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProjectRune.Models
{
    public class Skill
    {
        public string NaturalID { get; set; }
        public string Image { get => string.Format("{0}.png", NaturalID); }
        public string DisplayName { get => string.Format("{0}{1}", NaturalID.Substring(0, 1).ToUpper(), NaturalID.Substring(1)); }

        public string PrimaryColourHex { get; set; }
        public string SecondaryColourHex { get; set; }
        public Color PrimaryColour { get => ColourTools.CalculateColour(PrimaryColourHex); }
        public Color SecondaryColour { get => ColourTools.CalculateColour(SecondaryColourHex); }

        //Somehow calculate this lol
        public string DisplayLevel { get => "1/99"; }
    }
}
