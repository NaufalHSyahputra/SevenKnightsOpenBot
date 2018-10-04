using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SmartSelectPM
    {
        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 180,
            Y = 99,
            Color = 1838854,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 694,
            Y = 404,
            Color = 327680,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CelestialTowerButton = new PixelMapping
        {
            X = 182,
            Y = 222,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RaidButton = new PixelMapping
        {
            X = 402,
            Y = 194,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping TartarusButton = new PixelMapping
        {
            X = 610,
            Y = 240,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}