using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class MapSelectPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 163,
            Y = 39,
            Color = 4735544,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 327,
            Y = 144,
            Color = 16495891,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderRight = new PixelMapping
        {
            X = 487,
            Y = 355,
            Color = 14980352,
            Type = MappingType.ANCHOR
        };
    }
}