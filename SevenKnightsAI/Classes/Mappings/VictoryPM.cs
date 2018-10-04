using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class VictoryPM
    {
        public static readonly PixelMapping RibbonLeft = new PixelMapping
        {
            X = 308,
            Y = 39,
            Color = 16741893,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RibbonMiddle = new PixelMapping
        {
            X = 394,
            Y = 37,
            Color = 14603397,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RibbonRight = new PixelMapping
        {
            X = 503,
            Y = 41,
            Color = 16736258,
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