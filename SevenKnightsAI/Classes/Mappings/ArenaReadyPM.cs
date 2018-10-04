using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaReadyPM
    {
        #region Public Fields

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 664,
            Y = 408,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBackground = new PixelMapping //Letter R in "READY" Button
        {
            X = 664,
            Y = 408,
            Color = 13483157,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RecordBorder = new PixelMapping //Letter R in "RECORD" word
        {
            X = 585,
            Y = 72,
            Color = 14327058,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardBackground = new PixelMapping //Reward Button
        {
            X = 580,
            Y = 327,
            Color = 3415313,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectBorder = new PixelMapping //Collect Button "Yellow"
        {
            X = 751,
            Y = 324,
            Color = 13204484,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RubyPlus = new PixelMapping
        {
            X = 569,
            Y = 26,
            Color = 16503945,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle ArenaScore = new Rectangle
        {
            X = 711,
            Y = 158,
            Width = 52,
            Height = 22
        };

        #endregion Public Fields
    }
}