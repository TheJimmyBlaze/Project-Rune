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
        public string DisplayName { get => string.Format("{0}{1}", NaturalID.Substring(0, 1), NaturalID.Substring(1)); }

        public string ColourHex { get; set; }
        public Color Colour { get => ColourTools.CalculateColour(ColourHex); }

        //Somehow calculate this lol
        public string DisplayLevel { get => "1/99"; }
    }
}
