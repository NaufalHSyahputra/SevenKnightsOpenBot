namespace SevenKnightsAI.Classes.Mappings
{
    internal static class VictoryPM
    {
        public static readonly PixelMapping RibbonLeft = new PixelMapping
        {
            X = 368,
            Y = 41,
            Color = 1545470,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RibbonMiddle = new PixelMapping
        {
            X = 472,
            Y = 42,
            Color = 16317951,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RibbonRight = new PixelMapping
        {
            X = 600,
            Y = 48,
            Color = 1412605,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapToSkipArea = new PixelMapping
        {
            X = 501,
            Y = 458,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}