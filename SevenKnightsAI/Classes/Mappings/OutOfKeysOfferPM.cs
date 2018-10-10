using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class OutOfKeysOfferPM
    {
        public static readonly PixelMapping BuyButton = new PixelMapping
        {
            X = 448,
            Y = 335,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping BuyButtonBorder = new PixelMapping
        {
            X = 448,
            Y = 335,
            Color = 16769090,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping StartBG = new PixelMapping
        {
            X = 532,
            Y = 401,
            Color = 4868155,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 262,
            Y = 337,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedCross = new PixelMapping
        {
            X = 262,
            Y = 337,
            Color = 14105865,
            Type = MappingType.ANCHOR
        };
    }
}