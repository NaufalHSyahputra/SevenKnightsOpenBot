using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ShopBuyPopupPM
    {
        public static readonly PixelMapping BuyButton = new PixelMapping
        {
            X = 453,
            Y = 369,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 280,
            Y = 373,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 225,
            Y = 169,
            Color = 16047520,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderRight = new PixelMapping
        {
            X = 600,
            Y = 310,
            Color = 8020019,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RedCross = new PixelMapping
        {
            X = 280,
            Y = 373,
            Color = 13778185,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 453,
            Y = 369,
            Color = 16771146,
            Type = MappingType.ANCHOR
        };
    }
}