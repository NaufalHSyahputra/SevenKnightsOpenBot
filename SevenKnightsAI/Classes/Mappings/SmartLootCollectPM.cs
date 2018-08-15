using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SmartLootCollectPM
    {
        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 499,
            Y = 354,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 499,
            Y = 354,
            Color = 15900416,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OpenAllButton = new PixelMapping
        {
            X = 312,
            Y = 354,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CrossButton = new PixelMapping
        {
            X = 441,
            Y = 239,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}