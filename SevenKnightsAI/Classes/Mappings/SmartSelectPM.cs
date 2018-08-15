using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SmartSelectPM
    {
        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 261,
            Y = 114,
            Color = 8009740,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 492,
            Y = 114,
            Color = 11036177,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CelestialTowerButton = new PixelMapping
        {
            X = 199,
            Y = 241,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RaidButton = new PixelMapping
        {
            X = 417,
            Y = 230,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping TartarusButton = new PixelMapping
        {
            X = 637,
            Y = 229,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}