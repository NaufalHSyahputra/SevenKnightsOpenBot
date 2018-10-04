using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaStartPM
    {
        #region Public Fields

        public static readonly PixelMapping CombatTeamBorderLeft = new PixelMapping //First "A" in "ARENA"
        {
            X = 57,
            Y = 30,
            Color = 14204312,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CombatTeamBorderRight = new PixelMapping //"M" in "TEAM"
        {
            X = 204,
            Y = 69,
            Color = 16634990,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FormationBorderLeft = new PixelMapping
        {
            X = 288,
            Y = 109,
            Color = 15126421,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FormationBorderRight = new PixelMapping
        {
            X = 773,
            Y = 314,
            Color = 9070394,
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
            X = 322,
            Y = 25,
            Color = 12948309,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_1 = new PixelMapping    //เช็คตำแหน่ง 2
        {
            X = 342,
            Y = 24,
            Color = 15828767,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_2 = new PixelMapping    //เช็คตำแหน่ง 3
        {
            X = 361,
            Y = 27,
            Color = 10654377,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_3 = new PixelMapping   //เช็คตำแหน่ง 4
        {
            X = 381,
            Y = 27,
            Color = 12806433,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_4 = new PixelMapping    //ฝั่งขวาอันที่ 5 ไม่เต็ม 4 เต็ม
        {
            X = 401,
            Y = 28,
            Color = 8291783,
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