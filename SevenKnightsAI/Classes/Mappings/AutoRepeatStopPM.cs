namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AutoRepeatStopPM
    {
        public static readonly PixelMapping HideAutoButton = new PixelMapping
        {
            X = 9,
            Y = 491,
            Color = 4671303,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping BlueBar = new PixelMapping
        {
            X = 401,
            Y = 23,
            Color = 537675,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping HeroIcon = new PixelMapping
        {
            X = 316,
            Y = 426,
            Color = 14275024,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping PopupBorder = new PixelMapping
        {
            X = 543,
            Y = 425,
            Color = 14014169,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 377,
            Y = 429,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping YesButton = new PixelMapping
        {
            X = 593,
            Y = 425,
            Color = 0,
            Type = MappingType.BUTTON
        };

    }
}