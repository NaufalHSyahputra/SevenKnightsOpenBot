using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaEndPM
    {
        public static readonly PixelMapping ArenaButton = new PixelMapping
        {
            X = 751,
            Y = 337,
            Color = 14204499,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GetStrongerButton = new PixelMapping
        {
            X = 749,
            Y = 46,
            Color = 15785089,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping LobbyButton = new PixelMapping
        {
            X = 755,
            Y = 406,
            Color = 16177007,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Opponentbutton = new PixelMapping
        {
            X = 737,
            Y = 219,
            Color = 10712366,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButton = new PixelMapping
        {
            X = 749,
            Y = 166,
            Color = 6567170,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButtonBG = new PixelMapping
        {
            X = 751,
            Y = 128,
            Color = 4471326,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LobbyButtonBG = new PixelMapping
        {
            X = 756,
            Y = 390,
            Color = 2892560,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RankUpTik = new PixelMapping
        {
            X = 372,
            Y = 332,
            Color = 16775001,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle ArenaScore = new Rectangle
        {
            X = 184,
            Y = 396,
            Width = 144,
            Height = 44
        };
    }
}