using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TapToPlayPM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping //Red Ruby in "V"
        {
            X = 131,
            Y = 57,
            Color = 16730696,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping //Anywhere
        {
            X = 418,
            Y = 433,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}