using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureReadyPM
    {
        #region Public Fields

        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            X = 630,
            Y = 54,
            Color = 12925963,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 440,
            Y = 439,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBackground = new PixelMapping
        {
            X = 440,
            Y = 439,
            Color = 16050620,
            Type = MappingType.ANCHOR
        };

        #endregion Public Fields
    }
}