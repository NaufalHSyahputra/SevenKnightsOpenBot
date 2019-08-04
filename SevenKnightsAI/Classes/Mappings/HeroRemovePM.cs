namespace SevenKnightsAI.Classes.Mappings
{
    internal static class HeroRemovePM
    {
        public static readonly PixelMapping PositionButton = new PixelMapping
        {
            X = 736,
            Y = 496,
            Color = 12566723,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveAllButton = new PixelMapping
        {
            X = 531,
            Y = 496,
            Color = 5780016,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveButton = new PixelMapping
        {
            X = 927,
            Y = 498,
            Color = 7360847,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RemoveButtonIcon = new PixelMapping
        {
            X = 867,
            Y = 499,
            Color = 12497843,
            Type = MappingType.ANCHOR
        };
    }
}