using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ShopBuyFailedPopupPM
    {
        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 411,
            Y = 370,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 347,
            Y = 139,
            Color = 16298770,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderLeft2 = new PixelMapping
        {
            X = 225,
            Y = 234,
            Color = 9929300,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 399,
            Y = 353,
            Color = 2823680,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick2 = new PixelMapping
        {
            X = 363,
            Y = 374,
            Color = 16630309,
            Type = MappingType.ANCHOR
        };
    }
}