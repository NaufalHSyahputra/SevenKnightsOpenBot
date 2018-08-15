using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class PausePM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping //Red Ruby in "V"
        {
            X = 350,
            Y = 157,
            Color = 9260812,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping //Anywhere
        {
            X = 350,
            Y = 157,
            Color = 9260812,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ContinueButton = new PixelMapping //Anywhere
        {
            X = 247,
            Y = 245,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SettingButton = new PixelMapping //Anywhere
        {
            X = 358,
            Y = 246,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping LobbyButton = new PixelMapping //Anywhere
        {
            X = 476,
            Y = 246,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping //Anywhere
        {
            X = 595,
            Y = 244,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}