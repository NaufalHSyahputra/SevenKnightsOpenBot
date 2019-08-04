namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ShopBuyPopupPM
    {
        public static readonly PixelMapping BuyButton = new PixelMapping
        {
            X = 587,
            Y = 424,
            Color = 15308801,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 388,
            Y = 428,
            Color = 13382156,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 698,
            Y = 195,
            Color = 16771752,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderRight = new PixelMapping
        {
            X = 600,
            Y = 310,
            Color = 8020019,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RedCross = new PixelMapping
        {
            X = 388,
            Y = 428,
            Color = 13382156,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 587,
            Y = 424,
            Color = 15308801,
            Type = MappingType.ANCHOR
        };
    }
}