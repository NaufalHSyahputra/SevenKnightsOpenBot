namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TapToPlayPM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping //Red Ruby in "V"
        {
            X = 138,
            Y = 74,
            Color = 15014422,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping //Red Ruby in "V" Top
        {
            X = 217,
            Y = 119,
            Color = 15784807,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping //Anywhere
        {
            X = 479,
            Y = 478,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}