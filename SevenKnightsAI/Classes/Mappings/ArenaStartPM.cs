using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaStartPM
    {
        #region Public Fields

        public static readonly PixelMapping CombatTeamBorderLeft = new PixelMapping //First "A" in "ARENA"
        {
            X = 60,
            Y = 32,
            Color = 16578271,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CombatTeamBorderRight = new PixelMapping //"M" in "TEAM"
        {
            X = 219,
            Y = 82,
            Color = 15712605,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FormationBorderLeft = new PixelMapping
        {
            X = 794,
            Y = 120,
            Color = 14665873,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FormationBorderRight = new PixelMapping
        {
            X = 927,
            Y = 137,
            Color = 15587227,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FormationSelectBalance = new PixelMapping
        {
            X = 776,
            Y = 200,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping FormationSelectBasic = new PixelMapping
        {
            X = 488,
            Y = 200,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping FormationSelectDefense = new PixelMapping
        {
            X = 776,
            Y = 374,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping FormationSelectOffense = new PixelMapping
        {
            X = 488,
            Y = 374,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int HONOR_OFFSET_X = 227;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping Key_0 = new PixelMapping
        {
            X = 336,
            Y = 33,
            Color = 11797504,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_1 = new PixelMapping    //เช็คตำแหน่ง 2
        {
            X = 356,
            Y = 33,
            Color = 9700609,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_2 = new PixelMapping    //เช็คตำแหน่ง 3
        {
            X = 375,
            Y = 32,
            Color = 15430421,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_3 = new PixelMapping   //เช็คตำแหน่ง 4
        {
            X = 395,
            Y = 34,
            Color = 8723720,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_4 = new PixelMapping    //ฝั่งขวาอันที่ 5 ไม่เต็ม 4 เต็ม
        {
            X = 415,
            Y = 33,
            Color = 6424579,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_5 = new PixelMapping   //ฝั่งขวาอันที่ 5 เต็ม
        {
            X = 481,
            Y = 19,
            Color = 16075792,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageButton = new PixelMapping
        {
            X = 280,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Mastery_1 = new PixelMapping
        {
            X = 315,
            Y = 125,
            Color = 16637984,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Mastery_2 = new PixelMapping
        {
            X = 319,
            Y = 136,
            Color = 15257116,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Mastery_3 = new PixelMapping
        {
            X = 320,
            Y = 132,
            Color = 16769568,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MasteryButton = new PixelMapping
        {
            X = 302,
            Y = 156,
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
            X = 735,
            Y = 414,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}