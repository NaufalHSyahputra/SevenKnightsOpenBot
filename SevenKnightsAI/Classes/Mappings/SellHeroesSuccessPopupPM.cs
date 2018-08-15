using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SellHeroesSuccessPopupPM
    {
        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 450,
            Y = 422,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 450,
            Y = 422,
            Color = 16762922,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 487,
            Y = 88,
            Color = 4736059,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 317,
            Y = 212,
            Color = 16708251,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 324,
            Y = 226,
            Color = 16573827,
            Type = MappingType.ANCHOR
        };
    }
}