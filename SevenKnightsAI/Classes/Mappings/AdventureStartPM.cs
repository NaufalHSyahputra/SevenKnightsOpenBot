using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureStartPM
    {
        #region Public Fields

        public static readonly int GOLD_OFFSET_X = 364;
        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly int KEY_OFFSET_X = 363;
        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping KeyPlusButton = new PixelMapping
        {
            X = 425,
            Y = 37,
            Color = 16372359,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Auto_KeyPlusButton = new PixelMapping
        {
            X = 426,
            Y = 37,
            Color = 4865576,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Auto_StopButton = new PixelMapping
        {
            X = 754,
            Y = 422,
            Color = 5055248,
            Type = MappingType.BOTH
        };

        

        public static readonly PixelMapping Point1 = new PixelMapping //Question Mark Auto Repeat
        {
            X = 610,
            Y = 415,
            Color = 16777075,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping //Question Mark Boost Mode
        {
            X = 816,
            Y = 414,
            Color = 16777065,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AutoRepeatOn = new PixelMapping
        {
            X = 395,
            Y = 373,
            Color = 16704319,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AutoRepeatOff = new PixelMapping
        {
            X = 381,
            Y = 374,
            Color = 2365712,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle R_MapNumber = new Rectangle
        {
            X = 261,
            Y = 28,
            Width = 74,
            Height = 29
        };

        public static readonly PixelMapping UseFriendOn = new PixelMapping
        {
            X = 679,
            Y = 134,
            Color = 5448207,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping UseFriendOff = new PixelMapping
        {
            X = 679,
            Y = 136,
            Color = 16031744,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BootmodeOn = new PixelMapping
        {
            X = 529,
            Y = 374,
            Color = 16706119,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping BootmodeOff = new PixelMapping
        {
            X = 529,
            Y = 374,
            Color = 2694165,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping UsedBootModeButton = new PixelMapping
        {
            X = 529,
            Y = 374,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AutoSettingsBTN = new PixelMapping
        {
            X = 324,
            Y = 336,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}