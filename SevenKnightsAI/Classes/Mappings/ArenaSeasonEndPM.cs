namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaSeasonEndPM
    {
        public static readonly PixelMapping Point1 = new PixelMapping //A in ARENA top left
        {
            X = 62,
            Y = 37,
            Color = 4735802,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping //Ranking Yellow
        {
            X = 134,
            Y = 80,
            Color = 4535831,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupLeftBorder = new PixelMapping
        {
            X = 381,
            Y = 139,
            Color = 16693011,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupRightBorder = new PixelMapping
        {
            X = 427,
            Y = 357,
            Color = 12220672,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping
        {
            X = 427,
            Y = 357,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}