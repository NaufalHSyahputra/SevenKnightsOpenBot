using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TapToPlayPM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping //Red Ruby in "V"
        {
            X = 121,
            Y = 43,
            Color = 16767447,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping //Anywhere
        {
            X = 427,
            Y = 423,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}