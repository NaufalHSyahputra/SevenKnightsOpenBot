using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class NoMoreHeroPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 307,
            Y = 410,
            Color = 2692102,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 307,
            Y = 222,
            Color = 12398091,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderRight = new PixelMapping
        {
            X = 418,
            Y = 106,
            Color = 15970066,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping
        {
            X = 390,
            Y = 349,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}