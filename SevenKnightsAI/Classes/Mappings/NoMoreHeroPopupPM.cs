using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class NoMoreHeroPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 549,
            Y = 418,
            Color = 4868155,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 337,
            Y = 237,
            Color = 13840908,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderRight = new PixelMapping
        {
            X = 498,
            Y = 238,
            Color = 14562316,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping
        {
            X = 399,
            Y = 371,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}