namespace SevenKnightsAI.Classes.Mappings
{
    internal static class NoMoreHeroPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 450,
            Y = 58,
            Color = 3553338,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DimmedBGStart = new PixelMapping
        {
            X = 289,
            Y = 489,
            Color = 4671562,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 410,
            Y = 268,
            Color = 14672096,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderRight = new PixelMapping
        {
            X = 542,
            Y = 291,
            Color = 14013910,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping
        {
            X = 479,
            Y = 423,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}