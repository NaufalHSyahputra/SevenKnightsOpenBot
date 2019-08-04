namespace SevenKnightsAI.Classes.Mappings
{
    internal static class HeroJoinPM
    {
        #region Public Fields

        public static readonly PixelMapping JoinButton = new PixelMapping
        {
            X = 888,
            Y = 500,
            Color = 15058003,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping JoinButtonIcon = new PixelMapping
        {
            X = 890,
            Y = 495,
            Color = 9738141,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SellButton = new PixelMapping
        {
            X = 579,
            Y = 502,
            Color = 12959421,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping KeyLockButton = new PixelMapping
        {
            X = 208,
            Y = 508,
            Color = 6442786,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ItemButton = new PixelMapping
        {
            X = 832,
            Y = 279,
            Color = 0,
            Type = MappingType.BUTTON
        };
        #endregion Public Fields
    }
}