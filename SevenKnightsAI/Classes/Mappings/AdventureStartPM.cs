using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureStartPM
    {
        #region Public Fields

        public static readonly PixelMapping KeyPlusButton = new PixelMapping
        {
            X = 411,
            Y = 27,
            Color = 14727532,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Auto_KeyPlusButton = new PixelMapping
        {
            X = 413,
            Y = 23,
            Color = 1445895,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Auto_StopButton = new PixelMapping
        {
            X = 719,
            Y = 402,
            Color = 4661776,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AutoRepeatOn = new PixelMapping
        {
            X = 381,
            Y = 354,
            Color = 16699958,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AutoRepeatOff = new PixelMapping
        {
            X = 381,
            Y = 354,
            Color = 2562579,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AutoRepeatButton = new PixelMapping
        {
            X = 376,
            Y = 356,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly Rectangle R_MapNumber = new Rectangle
        {
            X = 39,
            Y = 15,
            Width = 281,
            Height = 30
        };

        public static readonly PixelMapping UseFriendOn = new PixelMapping
        {
            X = 643,
            Y = 125,
            Color = 12529677,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping UseFriendOff = new PixelMapping
        {
            X = 643,
            Y = 125,
            Color = 3677456,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BootmodeOn = new PixelMapping
        {
            X = 524,
            Y = 357,
            Color = 16705090,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping BootmodeOff = new PixelMapping
        {
            X = 524,
            Y = 357,
            Color = 2891286,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping UsedBootModeButton = new PixelMapping
        {
            X = 524,
            Y = 357,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AutoSettingsBTN = new PixelMapping
        {
            X = 315,
            Y = 320,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}