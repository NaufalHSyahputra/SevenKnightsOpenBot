using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaReadyPM
    {
        #region Public Fields

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 685,
            Y = 495,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBackground = new PixelMapping //Letter R in "READY" Button
        {
            X = 735,
            Y = 488,
            Color = 16113580,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RecordBorder = new PixelMapping //Letter R in "RECORD" word
        {
            X = 838,
            Y = 77,
            Color = 13027273,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardBackground = new PixelMapping //Reward Button
        {
            X = 869,
            Y = 119,
            Color = 1383467,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectBorder = new PixelMapping //Collect Button "Yellow"
        {
            X = 868,
            Y = 166,
            Color = 28395,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RubyPlus = new PixelMapping
        {
            X = 652,
            Y = 31,
            Color = 16777215,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle ArenaScore = new Rectangle
        {
            X = 618,
            Y = 144,
            Width = 64,
            Height = 25
        };

        #endregion Public Fields
    }
}