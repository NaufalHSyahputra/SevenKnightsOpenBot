using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class OutOfKeysOfferPM
    {
        public static readonly PixelMapping BuyButton = new PixelMapping
        {
            X = 532,
            Y = 398,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping BuyButtonBorder = new PixelMapping
        {
            X = 594,
            Y = 407,
            Color = 7875596,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping StartBG = new PixelMapping
        {
            X = 632,
            Y = 525,
            Color = 2362627,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 316,
            Y = 393,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedCross = new PixelMapping
        {
            X = 315,
            Y = 394,
            Color = 14171656,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SkipTodayButton = new PixelMapping
        {
            X = 715,
            Y = 408,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}