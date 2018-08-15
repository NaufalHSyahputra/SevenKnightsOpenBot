using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class HeroesSameTeamPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 411,
            Y = 110,
            Color = 2628875,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 271,
            Y = 219,
            Color = 15521435,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderRight = new PixelMapping
        {
            X = 723,
            Y = 363,
            Color = 8546106,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping
        {
            X = 503,
            Y = 420,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}