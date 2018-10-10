using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class OutOfKeysPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 309,
            Y = 394,
            Color = 4536605,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 268,
            Y = 331,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping NoButtonBorder = new PixelMapping
        {
            X = 268,
            Y = 331,
            Color = 15611652,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorder = new PixelMapping
        {
            X = 289,
            Y = 239,
            Color = 10259553,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ShopButton = new PixelMapping
        {
            X = 449,
            Y = 334,
            Color = 16770889,
            Type = MappingType.BUTTON
        };
    }
}