namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaFightPM
    {
        public static readonly PixelMapping ChatButton = new PixelMapping
        {
            X = 276,
            Y = 63,
            Color = 11662079,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping PauseButton = new PixelMapping
        {
            X = 685,
            Y = 62,
            Color = 12645374,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping TimeBorder = new PixelMapping // < Button bottom
        {
            X = 12,
            Y = 494,
            Color = 13684944,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point12 = new PixelMapping
        {
            X = 275,
            Y = 64,
            Color = 11137535,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Point22 = new PixelMapping
        {
            X = 686,
            Y = 66,
            Color = 10743807,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Point32 = new PixelMapping // < Button bottom
        {
            X = 687,
            Y = 67,
            Color = 10087934,
            Type = MappingType.ANCHOR
        };
    }
}