using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TapToPlayPM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping //Red Ruby in "V"
        {
            X = 134,
            Y = 46,
            Color = 16713220,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping //Anywhere
        {
            X = 408,
            Y = 454,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}