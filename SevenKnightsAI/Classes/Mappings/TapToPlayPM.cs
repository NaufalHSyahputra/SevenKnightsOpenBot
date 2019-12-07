namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TapToPlayPM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping //Red Ruby in "V"
        {
            X = 245,
            Y = 173,
            Color = 16771248,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping //Red Ruby in "V" Top
        {
            X = 298,
            Y = 165,
            Color = 16774345,
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