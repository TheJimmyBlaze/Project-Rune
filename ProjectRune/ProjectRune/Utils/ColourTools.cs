using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProjectRune.Utils
{
    public static class ColourTools
    {
        public static Color CalculateColour(string colourHex)
        {
            const string HASH = "#";

            if (string.IsNullOrEmpty(colourHex))
                return Color.Transparent;

            if (!colourHex.StartsWith(HASH))
                colourHex = string.Format("#{0}", colourHex);
            
            return Color.FromHex(colourHex);
        }
    }
}
