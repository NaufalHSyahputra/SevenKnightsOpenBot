using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ShopBuyFailedPopupPM
    {
        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 411,
            Y = 355,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 384,
            Y = 307,
            Color = 10851687,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderLeft2 = new PixelMapping
        {
            X = 583,
            Y = 308,
            Color = 8873786,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 351,
            Y = 359,
            Color = 16759838,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick2 = new PixelMapping
        {
            X = 411,
            Y = 355,
            Color = 14388738,
            Type = MappingType.ANCHOR
        };
    }
}