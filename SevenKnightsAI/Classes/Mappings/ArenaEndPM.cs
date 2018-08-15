using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaEndPM
    {
        public static readonly PixelMapping ArenaButton = new PixelMapping
        {
            X = 758,
            Y = 335,
            Color = 16111214,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GetStrongerButton = new PixelMapping
        {
            X = 768,
            Y = 68,
            Color = 15522426,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping LobbyButton = new PixelMapping
        {
            X = 779,
            Y = 419,
            Color = 16177007,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Opponentbutton = new PixelMapping
        {
            X = 783,
            Y = 248,
            Color = 16177007,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButton = new PixelMapping
        {
            X = 772,
            Y = 142,
            Color = 15913580,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButtonBG = new PixelMapping
        {
            X = 775,
            Y = 140,
            Color = 4076571,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LobbyButtonBG = new PixelMapping
        {
            X = 771,
            Y = 408,
            Color = 2234372,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RankUpTik = new PixelMapping
        {
            X = 383,
            Y = 352,
            Color = 16767034,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle ArenaScore = new Rectangle
        {
            X = 188,
            Y = 415,
            Width = 159,
            Height = 49
        };
    }
}