using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaFightPM
    {
        public static readonly PixelMapping ChatButton = new PixelMapping
        {
            X = 804,
            Y = 50,
            Color = 12297052,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping PauseButton = new PixelMapping
        {
            X = 806,
            Y = 92,
            Color = 13745783,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping TimeBorder = new PixelMapping
        {
            X = 480,
            Y = 25,
            Color = 1706762,
            Type = MappingType.ANCHOR
        };
    }
}