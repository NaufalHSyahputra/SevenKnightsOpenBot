using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class LandingPM
    {
        public static readonly PixelMapping CharacterFace = new PixelMapping
        {
            X = 834,
            Y = 202,
            Color = 15853270,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Moon = new PixelMapping
        {
            X = 64,
            Y = 68,
            Color = 15460326,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Shield = new PixelMapping
        {
            X = 744,
            Y = 442,
            Color = 3615505,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LeftCheck = new PixelMapping
        {
            X = 145,
            Y = 445,
            Color = 3287325,
            Type = MappingType.ANCHOR
        };
    }
}