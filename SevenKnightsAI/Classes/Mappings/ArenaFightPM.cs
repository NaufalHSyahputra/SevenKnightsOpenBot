using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaFightPM
    {
        public static readonly PixelMapping ChatButton = new PixelMapping
        {
            X = 779,
            Y = 33,
            Color = 13745784,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping PauseButton = new PixelMapping
        {
            X = 771,
            Y = 77,
            Color = 14404485,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping TimeBorder = new PixelMapping
        {
            X = 400,
            Y = 56,
            Color = 3085843,
            Type = MappingType.ANCHOR
        };
    }
}