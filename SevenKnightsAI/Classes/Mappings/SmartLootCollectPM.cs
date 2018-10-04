using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SmartLootCollectPM
    {
        public static readonly PixelMapping Point1 = new PixelMapping //dimmed
        {
            X = 471,
            Y = 62,
            Color = 9869209,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 584,
            Y = 63,
            Color = 7435126,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Card = new PixelMapping
        {
            X = 142,
            Y = 95,
            Color = 10130573,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OpenAllButton = new PixelMapping
        {
            X = 602,
            Y = 401,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}