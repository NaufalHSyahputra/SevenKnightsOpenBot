using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class HeroRemovePM
    {
        public static readonly PixelMapping PositionButton = new PixelMapping
        {
            X = 448,
            Y = 422,
            Color = 15123797,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveAllButton = new PixelMapping
        {
            X = 536,
            Y = 410,
            Color = 16049284,
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
            X = 748,
            Y = 411,
            Color = 16049284,
            Type = MappingType.ANCHOR
        };
    }
}