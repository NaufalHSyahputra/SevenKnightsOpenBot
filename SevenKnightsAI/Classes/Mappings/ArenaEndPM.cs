using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaEndPM
    {
        public static readonly PixelMapping ArenaButton = new PixelMapping
        {
            X = 738,
            Y = 303,
            Color = 11697461,
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
            X = 750,
            Y = 128,
            Color = 15124070,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButtonBG = new PixelMapping
        {
            X = 771,
            Y = 139,
            Color = 3944986,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LobbyButtonBG = new PixelMapping
        {
            X = 778,
            Y = 420,
            Color = 4734753,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RankUpTik = new PixelMapping
        {
            X = 385,
            Y = 350,
            Color = 16771403,
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