using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaReadyPM
    {
        #region Public Fields

        public static readonly int HONOR_OFFSET_X = 228;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 591,
            Y = 433,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBackground = new PixelMapping //Letter R in "READY" Button
        {
            X = 591,
            Y = 433,
            Color = 10845528,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RecordBorder = new PixelMapping //Letter R in "RECORD" word
        {
            X = 604,
            Y = 84,
            Color = 16627475,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardBackground = new PixelMapping //Reward Button
        {
            X = 509,
            Y = 341,
            Color = 3677714,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectBorder = new PixelMapping //Collect Button "Yellow"
        {
            X = 685,
            Y = 347,
            Color = 14392323,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RubyPlus = new PixelMapping
        {
            X = 589,
            Y = 35,
            Color = 16776114,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle ArenaScore = new Rectangle
        {
            X = 726,
            Y = 168,
            Width = 58,
            Height = 30
        };

        public static readonly int RUBY_OFFSET_X = 229;

        public static readonly int RUBY_OFFSET_Y = 0;

        #endregion Public Fields
    }
}