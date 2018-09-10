using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SmartLootCollectPM
    {
        public static readonly PixelMapping Point1 = new PixelMapping //dimmed
        {
            X = 584,
            Y = 424,
            Color = 13488340,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 703,
            Y = 115,
            Color = 11908534,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Card = new PixelMapping
        {
            X = 177,
            Y = 111,
            Color = 7626836,
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