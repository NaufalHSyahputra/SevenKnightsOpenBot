namespace SevenKnightsAI.Classes.Mappings
{
    internal static class NoticePM
    {
        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            X = 936,
            Y = 31,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping TopBorderLeft = new PixelMapping
        {
            X = 931,
            Y = 29,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TopBorderRight = new PixelMapping
        {
            X = 938,
            Y = 28,
            Color = 16777215,
            Type = MappingType.ANCHOR
        };
    }
}