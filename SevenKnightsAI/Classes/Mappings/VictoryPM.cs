using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class VictoryPM
    {
        public static readonly PixelMapping RibbonLeft = new PixelMapping
        {
            X = 323,
            Y = 52,
            Color = 16741893,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RibbonMiddle = new PixelMapping
        {
            X = 410,
            Y = 51,
            Color = 6835972,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RibbonRight = new PixelMapping
        {
            X = 514,
            Y = 61,
            Color = 16736514,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapToSkipArea = new PixelMapping
        {
            X = 411,
            Y = 434,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}