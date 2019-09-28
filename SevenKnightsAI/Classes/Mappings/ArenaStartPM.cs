using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaStartPM
    {
        #region Public Fields

        public static readonly PixelMapping CombatTeamBorderLeft = new PixelMapping //First "A" in "ARENA"
        {
            X = 69,
            Y = 485,
            Color = 12500929,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ArenaLoopOn = new PixelMapping //First "A" in "ARENA"
        {
            X = 358,
            Y = 441,
            Color = 2729964,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ArenaLoop = new PixelMapping //First "A" in "ARENA"
        {
            X = 358,
            Y = 441,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ArenaLoopOff = new PixelMapping //First "A" in "ARENA"
        {
            X = 358,
            Y = 441,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FormationBorderLeft = new PixelMapping
        {
            X = 298,
            Y = 493,
            Color = 266018,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CombatTeamBorderRight = new PixelMapping //Mastery Button
        {
            X = 722,
            Y = 483,
            Color = 12786986,
            Type = MappingType.ANCHOR
        };

        public static readonly int HONOR_OFFSET_X = 227;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping Key_0 = new PixelMapping
        {
            X = 457,
            Y = 33,
            Color = 6184543,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_1 = new PixelMapping    //เช็คตำแหน่ง 2
        {
            X = 439,
            Y = 33,
            Color = 6513508,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_2 = new PixelMapping    //เช็คตำแหน่ง 3
        {
            X = 421,
            Y = 35,
            Color = 8026490,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_3 = new PixelMapping   //เช็คตำแหน่ง 4
        {
            X = 402,
            Y = 35,
            Color = 8026747,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_4 = new PixelMapping    //ฝั่งขวาอันที่ 5 ไม่เต็ม 4 เต็ม
        {
            X = 382,
            Y = 32,
            Color = 7171438,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageButton = new PixelMapping
        {
            X = 484,
            Y = 33,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly Rectangle R_Time = new Rectangle
        {
            X = 498,
            Y = 19,
            Width = 50,
            Height = 20
        };

        public static readonly int RUBY_OFFSET_X = 223;

        public static readonly int RUBY_OFFSET_Y = 0;

        public static readonly PixelMapping StartButton = new PixelMapping
        {
            X = 586,
            Y = 488,
            Color = 16113323,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}