using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class PausePM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping //Red Ruby in "V"
        {
            X = 338,
            Y = 150,
            Color = 9784327,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping //Anywhere
        {
            X = 460,
            Y = 145,
            Color = 8537094,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ContinueButton = new PixelMapping //Anywhere
        {
            X = 243,
            Y = 235,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SettingButton = new PixelMapping //Anywhere
        {
            X = 347,
            Y = 235,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping LobbyButton = new PixelMapping //Anywhere
        {
            X = 463,
            Y = 232,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping //Anywhere
        {
            X = 572,
            Y = 227,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}