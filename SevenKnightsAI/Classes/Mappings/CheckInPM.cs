using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class CheckInPM
    {
        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            X = 899,
            Y = 52,
            Color = 13254668,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping BorderTopLeft = new PixelMapping
        {
            X = 41,
            Y = 29,
            Color = 12890515,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping BorderRightBottom = new PixelMapping
        {
            X = 918,
            Y = 510,
            Color = 9400921,
            Type = MappingType.ANCHOR
        };
    }
}