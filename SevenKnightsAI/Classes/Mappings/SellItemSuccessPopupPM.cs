using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SellItemSuccessPopupPM
    {
        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 388,
            Y = 359,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 388,
            Y = 359,
            Color = 16756497,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 60,
            Y = 390,
            Color = 4798235,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 452,
            Y = 295,
            Color = 8742458,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 398,
            Y = 146,
            Color = 12617742,
            Type = MappingType.ANCHOR
        };
    }
}