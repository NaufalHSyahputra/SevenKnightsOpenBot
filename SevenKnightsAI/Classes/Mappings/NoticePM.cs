using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class NoticePM
    {
        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            X = 804,
            Y = 29,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping TopBorderLeft = new PixelMapping
        {
            X = 804,
            Y = 29,
            Color = 3289650,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TopBorderRight = new PixelMapping
        {
            X = 807,
            Y = 34,
            Color = 15856113,
            Type = MappingType.ANCHOR
        };
        /*
         * BS 3 Code
         * public static readonly PixelMapping TopBorderLeft = new PixelMapping
        {
            X = 99,
            Y = 66,
            Color = 16763904,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TopBorderRight = new PixelMapping
        {
            X = 986,
            Y = 570,
            Color = 16763904,
            Type = MappingType.ANCHOR
        };*/
    }
}