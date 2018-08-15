using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SellItemConfirmPopupPM
    {
        public static readonly PixelMapping DimmedBG_1 = new PixelMapping
        {
            X = 64,
            Y = 389,
            Color = 3613455,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DimmedBG_2 = new PixelMapping
        {
            X = 406,
            Y = 79,
            Color = 4273941,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 274,
            Y = 353,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedCross = new PixelMapping
        {
            X = 274,
            Y = 353,
            Color = 14105865,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SellButton = new PixelMapping
        {
            X = 458,
            Y = 352,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 458,
            Y = 352,
            Color = 16767291,
            Type = MappingType.ANCHOR
        };
    }
}