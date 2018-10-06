using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class HeroRemovePM
    {
        public static readonly PixelMapping PositionButton = new PixelMapping
        {
            X = 432,
            Y = 398,
            Color = 16049284,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveAllButton = new PixelMapping
        {
            X = 534,
            Y = 393,
            Color = 13084487,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveButton = new PixelMapping
        {
            X = 748,
            Y = 411,
            Color = 16049284,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveButtonIcon = new PixelMapping
        {
            X = 744,
            Y = 394,
            Color = 15058003,
            Type = MappingType.ANCHOR
        };
    }
}