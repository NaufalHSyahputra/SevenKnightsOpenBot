using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class OutOfKeysPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 564,
            Y = 79,
            Color = 3222044,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 322,
            Y = 349,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping NoButtonBorder = new PixelMapping
        {
            X = 393,
            Y = 348,
            Color = 13612671,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorder = new PixelMapping
        {
            X = 440,
            Y = 239,
            Color = 13709580,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ShopButton = new PixelMapping
        {
            X = 457,
            Y = 355,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}