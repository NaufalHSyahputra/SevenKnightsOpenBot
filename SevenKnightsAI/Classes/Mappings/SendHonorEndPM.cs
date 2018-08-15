using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SendHonorEndPM
    {

        public static readonly PixelMapping bordertopleft = new PixelMapping
        {
            X = 448,
            Y = 127,
            Color = 13932560,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping borderbottomright = new PixelMapping
        {
            X = 555,
            Y = 281,
            Color = 10720101,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DimmedInGameTab = new PixelMapping
        {
            X = 502,
            Y = 84,
            Color = 3613185,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DimmedFBTab = new PixelMapping
        {
            X = 76,
            Y = 86,
            Color = 3481857,
            Type = MappingType.ANCHOR
        };

    }
}