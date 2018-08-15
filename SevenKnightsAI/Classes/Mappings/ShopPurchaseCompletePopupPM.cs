using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ShopPurchaseCompletePopupPM
    {
        public static readonly PixelMapping AgainButtonBorder= new PixelMapping
        {
            X = 182,
            Y = 443,
            Color = 8088381,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AgainButton = new PixelMapping
        {
            X = 124,
            Y = 439,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping OKButtonBorder = new PixelMapping
        {
            X = 790,
            Y = 436,
            Color = 16177007,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 790,
            Y = 436,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}