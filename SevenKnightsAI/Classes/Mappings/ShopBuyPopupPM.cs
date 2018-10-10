using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ShopBuyPopupPM
    {
        public static readonly PixelMapping BuyButton = new PixelMapping
        {
            X = 440,
            Y = 354,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 271,
            Y = 356,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 215,
            Y = 154,
            Color = 15587227,
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
            X = 271,
            Y = 356,
            Color = 14040329,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 440,
            Y = 354,
            Color = 16768576,
            Type = MappingType.ANCHOR
        };
    }
}