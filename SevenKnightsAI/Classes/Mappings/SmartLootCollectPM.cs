using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SmartLootCollectPM
    {
        public static readonly PixelMapping Point1 = new PixelMapping //dimmed
        {
            X = 593,
            Y = 419,
            Color = 12107204,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 609,
            Y = 70,
            Color = 13750994,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Card = new PixelMapping
        {
            X = 93,
            Y = 423,
            Color = 5065801,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OpenAllButton = new PixelMapping
        {
            X = 616,
            Y = 422, 
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CrossButton = new PixelMapping
        {
            X = 681,
            Y = 71,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}