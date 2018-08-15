using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureReadyPM
    {
        #region Public Fields

        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            X = 623,
            Y = 75,
            Color = 12925963,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 464,
            Y = 436,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBackground = new PixelMapping
        {
            X = 402,
            Y = 375,
            Color = 12419895,
            Type = MappingType.ANCHOR
        };

        #endregion Public Fields
    }
}