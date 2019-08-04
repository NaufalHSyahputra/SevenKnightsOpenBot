using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaEndPM
    {
        public static readonly PixelMapping ArenaButton = new PixelMapping
        {
            X = 918,
            Y = 249,
            Color = 14672096,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GetStrongerButton = new PixelMapping
        {
            X = 903,
            Y = 56,
            Color = 15461097,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping LobbyButton = new PixelMapping
        {
            X = 903,
            Y = 328,
            Color = 14013911,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping LobbyLoseButton = new PixelMapping
        {
            X = 885,
            Y = 426,
            Color = 13553362,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Opponentbutton = new PixelMapping
        {
            X = 915,
            Y = 160,
            Color = 15132905,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButton = new PixelMapping
        {
            X = 917,
            Y = 55,
            Color = 13685460,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ArenaLoseButton = new PixelMapping
        {
            X = 896,
            Y = 357,
            Color = 16250872,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartLoseButton = new PixelMapping
        {
            X = 917,
            Y = 161,
            Color = 15329769,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping LobbyButtonBG = new PixelMapping
        {
            X = 487,
            Y = 88,
            Color = 14738926,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ArenaRankUpPoint1 = new PixelMapping
        {
            X = 470,
            Y = 144,
            Color = 6181182,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ArenaRankUpPoint2 = new PixelMapping
        {
            X = 495,
            Y = 438,
            Color = 11771261,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RankUpTap = new PixelMapping
        {
            X = 477,
            Y = 245,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly Rectangle ArenaScore = new Rectangle
        {
            X = 309,
            Y = 482,
            Width = 300,
            Height = 40
        };

        public static readonly Rectangle ArenaRewardScore = new Rectangle
        {
            X = 362,
            Y = 485,
            Width = 100,
            Height = 40
        };
    }
}