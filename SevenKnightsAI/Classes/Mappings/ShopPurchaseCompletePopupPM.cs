using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ShopPurchaseCompletePopupPM
    {
        public static readonly PixelMapping AgainButtonBorder= new PixelMapping
        {
            X = 80,
            Y = 426,
            Color = 12492608,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AgainButton = new PixelMapping
        {
            X = 80,
            Y = 426,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping OKButtonBorder = new PixelMapping
        {
            X = 765,
            Y = 414,
            Color = 16177007,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 765,
            Y = 414,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}