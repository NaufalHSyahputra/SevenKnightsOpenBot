using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class HeroJoinPM
    {
        #region Public Fields

        public static readonly PixelMapping JoinButton = new PixelMapping
        {
            X = 888,
            Y = 500,
            Color = 15058003,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping JoinButtonIcon = new PixelMapping
        {
            X = 741,
            Y = 391,
            Color = 15058003,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SellButton = new PixelMapping
        {
            X = 519,
            Y = 404,
            Color = 15454570,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping KeyLockButton = new PixelMapping
        {
            X = 208,
            Y = 508,
            Color = 6442786,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ItemButton = new PixelMapping
        {
            X = 707,
            Y = 244,
            Color = 0,
            Type = MappingType.BUTTON
        };
        #endregion Public Fields
    }
}