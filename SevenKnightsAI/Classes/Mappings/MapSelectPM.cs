using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class MapSelectPM
    {
        #region Public Fields

        public static readonly PixelMapping BottomRightPanel = new PixelMapping
        {
            X = 24,
            Y = 440,
            Color = 4138004,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuickStartLeftButton = new PixelMapping
        {
            X = 629,
            Y = 429,
            Color = 14865338,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartMidButton = new PixelMapping
        {
            X = 717,
            Y = 430,
            Color = 14799288,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping QuickStartMidIcon = new PixelMapping
        {
            X = 711,
            Y = 419,
            Color = 13012809,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MidBottomBTN = new PixelMapping
        {
            X = 704,
            Y = 443,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AishaBoatLeft = new PixelMapping
        {
            X = 689,
            Y = 420,
            Color = 13806711,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AishaBoatRight = new PixelMapping
        {
            X = 710,
            Y = 428,
            Color = 16576463,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RightBottomBTN = new PixelMapping
        {
            X = 776,
            Y = 416,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping DifficultyBox = new PixelMapping
        {
            X = 108,
            Y = 451,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping MoonBoatLitLeft = new PixelMapping
        {
            X = 775,
            Y = 417,
            Color = 16710120,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MoonLitBoatRight = new PixelMapping
        {
            X = 791,
            Y = 432,
            Color = 16180413,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DifficultyBoxExpanded = new PixelMapping
        {
            X = 17,
            Y = 416,
            Color = 13480829,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DifficultyBoxSelectEasy = new PixelMapping
        {
            X = 79,
            Y = 412,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping DifficultyBoxSelectNormal = new PixelMapping
        {
            X = 83,
            Y = 383,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping DifficultyBoxSelectHard = new PixelMapping
        {
            X = 81,
            Y = 349,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 355;
        public static readonly int GOLD_OFFSET_Y = 0;
        public static readonly int KEY_OFFSET_X = 350;
        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping NextButton = new PixelMapping
        {
            X = 805,
            Y = 248,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PreviousButton = new PixelMapping
        {
            X = 20,
            Y = 245,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int RUBY_OFFSET_X = 364;
        public static readonly int RUBY_OFFSET_Y = 0;

        public static readonly PixelMapping World1Anchor_1 = new PixelMapping
        {
            X = 484,
            Y = 139,
            Color = 4202254,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World1Anchor_2 = new PixelMapping
        {
            X = 302,
            Y = 303,
            Color = 5454339,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World1Stage1 = new PixelMapping
        {
            X = 194,
            Y = 314,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World1Stage10 = new PixelMapping
        {
            X = 470,
            Y = 377,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World1Stage2 = new PixelMapping
        {
            X = 203,
            Y = 184,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World1Stage3 = new PixelMapping
        {
            X = 327,
            Y = 152,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World1Stage4 = new PixelMapping
        {
            X = 457,
            Y = 237,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World1Stage5 = new PixelMapping
        {
            X = 560,
            Y = 182,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World1Stage6 = new PixelMapping
        {
            X = 668,
            Y = 164,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World1Stage7 = new PixelMapping
        {
            X = 731,
            Y = 227,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World1Stage8 = new PixelMapping
        {
            X = 692,
            Y = 316,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World1Stage9 = new PixelMapping
        {
            X = 576,
            Y = 340,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World2Anchor_1 = new PixelMapping
        {
            X = 564,
            Y = 106,
            Color = 3087889,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World2Anchor_2 = new PixelMapping
        {
            X = 273,
            Y = 74,
            Color = 2761233,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World2Stage1 = new PixelMapping
        {
            X = 465,
            Y = 151,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World2Stage10 = new PixelMapping
        {
            X = 449,
            Y = 374,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World2Stage2 = new PixelMapping
        {
            X = 555,
            Y = 239,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World2Stage3 = new PixelMapping
        {
            X = 497,
            Y = 292,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World2Stage4 = new PixelMapping
        {
            X = 363,
            Y = 247,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World2Stage5 = new PixelMapping
        {
            X = 280,
            Y = 154,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World2Stage6 = new PixelMapping
        {
            X = 110,
            Y = 193,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World2Stage7 = new PixelMapping
        {
            X = 131,
            Y = 307,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World2Stage8 = new PixelMapping
        {
            X = 216,
            Y = 386,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World2Stage9 = new PixelMapping
        {
            X = 356,
            Y = 361,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World3Anchor_1 = new PixelMapping
        {
            X = 412,
            Y = 287,
            Color = 10580014,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World3Anchor_2 = new PixelMapping
        {
            X = 400,
            Y = 219,
            Color = 7953451,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World3Stage1 = new PixelMapping
        {
            X = 269,
            Y = 143,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World3Stage10 = new PixelMapping
        {
            X = 443,
            Y = 127,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World3Stage2 = new PixelMapping
        {
            X = 277,
            Y = 260,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World3Stage3 = new PixelMapping
        {
            X = 144,
            Y = 254,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World3Stage4 = new PixelMapping
        {
            X = 95,
            Y = 346,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World3Stage5 = new PixelMapping
        {
            X = 242,
            Y = 381,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World3Stage6 = new PixelMapping
        {
            X = 361,
            Y = 390,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World3Stage7 = new PixelMapping
        {
            X = 491,
            Y = 387,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World3Stage8 = new PixelMapping
        {
            X = 533,
            Y = 307,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World3Stage9 = new PixelMapping
        {
            X = 506,
            Y = 207,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World4Anchor_1 = new PixelMapping
        {
            X = 336,
            Y = 225,
            Color = 6904362,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World4Anchor_2 = new PixelMapping
        {
            X = 182,
            Y = 188,
            Color = 3811874,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World4Stage1 = new PixelMapping
        {
            X = 249,
            Y = 386,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World4Stage10 = new PixelMapping
        {
            X = 681,
            Y = 243,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World4Stage2 = new PixelMapping
        {
            X = 217,
            Y = 292,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World4Stage3 = new PixelMapping
        {
            X = 268,
            Y = 187,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World4Stage4 = new PixelMapping
        {
            X = 401,
            Y = 167,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World4Stage5 = new PixelMapping
        {
            X = 524,
            Y = 155,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World4Stage6 = new PixelMapping
        {
            X = 458,
            Y = 260,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World4Stage7 = new PixelMapping
        {
            X = 374,
            Y = 342,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World4Stage8 = new PixelMapping
        {
            X = 476,
            Y = 389,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World4Stage9 = new PixelMapping
        {
            X = 561,
            Y = 326,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World5Anchor_1 = new PixelMapping
        {
            X = 374,
            Y = 301,
            Color = 5977881,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World5Anchor_2 = new PixelMapping
        {
            X = 229,
            Y = 414,
            Color = 2043670,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World5Stage1 = new PixelMapping
        {
            X = 216,
            Y = 352,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World5Stage10 = new PixelMapping
        {
            X = 733,
            Y = 188,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World5Stage2 = new PixelMapping
        {
            X = 321,
            Y = 434,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World5Stage3 = new PixelMapping
        {
            X = 431,
            Y = 381,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World5Stage4 = new PixelMapping
        {
            X = 317,
            Y = 300,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World5Stage5 = new PixelMapping
        {
            X = 379,
            Y = 160,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World5Stage6 = new PixelMapping
        {
            X = 467,
            Y = 249,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World5Stage7 = new PixelMapping
        {
            X = 467,
            Y = 249,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World5Stage8 = new PixelMapping
        {
            X = 631,
            Y = 284,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World5Stage9 = new PixelMapping
        {
            X = 589,
            Y = 152,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World6Anchor_1 = new PixelMapping
        {
            X = 466,
            Y = 216,
            Color = 6173977,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World6Anchor_2 = new PixelMapping
        {
            X = 513,
            Y = 104,
            Color = 2960724,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World6Stage1 = new PixelMapping
        {
            X = 399,
            Y = 426,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World6Stage10 = new PixelMapping
        {
            X = 737,
            Y = 251,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World6Stage2 = new PixelMapping
        {
            X = 238,
            Y = 419,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World6Stage3 = new PixelMapping
        {
            X = 156,
            Y = 304,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World6Stage4 = new PixelMapping
        {
            X = 254,
            Y = 157,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World6Stage5 = new PixelMapping
        {
            X = 405,
            Y = 152,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World6Stage6 = new PixelMapping
        {
            X = 339,
            Y = 302,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World6Stage7 = new PixelMapping
        {
            X = 489,
            Y = 307,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World6Stage8 = new PixelMapping
        {
            X = 625,
            Y = 354,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World6Stage9 = new PixelMapping
        {
            X = 575,
            Y = 189,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World7Anchor_1 = new PixelMapping
        {
            X = 287,
            Y = 345,
            Color = 1050113,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World7Anchor_2 = new PixelMapping
        {
            X = 369,
            Y = 133,
            Color = 4791564,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World7Stage1 = new PixelMapping
        {
            X = 726,
            Y = 205,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World7Stage10 = new PixelMapping
        {
            X = 723,
            Y = 324,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World7Stage2 = new PixelMapping
        {
            X = 643,
            Y = 233,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World7Stage3 = new PixelMapping
        {
            X = 558,
            Y = 176,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World7Stage4 = new PixelMapping
        {
            X = 438,
            Y = 155,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World7Stage5 = new PixelMapping
        {
            X = 290,
            Y = 220,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World7Stage6 = new PixelMapping
        {
            X = 436,
            Y = 291,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World7Stage7 = new PixelMapping
        {
            X = 390,
            Y = 386,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World7Stage8 = new PixelMapping
        {
            X = 505,
            Y = 383,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World7Stage9 = new PixelMapping
        {
            X = 592,
            Y = 320,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_1Anchor_1 = new PixelMapping
        {
            X = 193,
            Y = 268,
            Color = 2366522,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World8_1Anchor_2 = new PixelMapping
        {
            X = 653,
            Y = 328,
            Color = 14204896,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World8_1Stage1 = new PixelMapping
        {
            X = 122,
            Y = 168,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_1Stage2 = new PixelMapping
        {
            X = 272,
            Y = 195,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_1Stage3 = new PixelMapping
        {
            X = 298,
            Y = 305,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_1Stage4 = new PixelMapping
        {
            X = 332,
            Y = 413,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_1Stage5 = new PixelMapping
        {
            X = 463,
            Y = 417,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_2Anchor_1 = new PixelMapping
        {
            X = 543,
            Y = 290,
            Color = 12558280,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World8_2Anchor_2 = new PixelMapping
        {
            X = 645,
            Y = 239,
            Color = 3289673,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World8_2Stage10 = new PixelMapping
        {
            X = 514,
            Y = 187,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_2Stage6 = new PixelMapping
        {
            X = 259,
            Y = 435,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_2Stage7 = new PixelMapping
        {
            X = 325,
            Y = 351,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_2Stage8 = new PixelMapping
        {
            X = 360,
            Y = 263,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_2Stage9 = new PixelMapping
        {
            X = 433,
            Y = 185,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_3Anchor_1 = new PixelMapping
        {
            X = 446,
            Y = 269,
            Color = 10254905,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World8_3Anchor_2 = new PixelMapping
        {
            X = 329,
            Y = 116,
            Color = 13614805,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World8_3Stage11 = new PixelMapping
        {
            X = 619,
            Y = 310,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_3Stage12 = new PixelMapping
        {
            X = 501,
            Y = 302,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_3Stage13 = new PixelMapping
        {
            X = 378,
            Y = 256,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_3Stage14 = new PixelMapping
        {
            X = 412,
            Y = 153,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_3Stage15 = new PixelMapping
        {
            X = 215,
            Y = 199,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_4Anchor_1 = new PixelMapping
        {
            X = 605,
            Y = 306,
            Color = 16236436    ,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World8_4Anchor_2 = new PixelMapping
        {
            X = 500,
            Y = 89,
            Color = 16643265,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World8_4Stage16 = new PixelMapping
        {
            X = 246,
            Y = 164,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_4Stage17 = new PixelMapping
        {
            X = 411,
            Y = 142,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_4Stage18 = new PixelMapping
        {
            X = 560,
            Y = 138,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_4Stage19 = new PixelMapping
        {
            X = 443,
            Y = 275,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World8_4Stage20 = new PixelMapping
        {
            X = 543,
            Y = 373,
            Color = 0,
            Type = MappingType.BUTTON
        };

        //
        public static readonly PixelMapping World9_1Anchor_1 = new PixelMapping
        {
            X = 320,
            Y = 282,
            Color = 9865025,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World9_1Anchor_2 = new PixelMapping
        {
            X = 424,
            Y = 282,
            Color = 9135919,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World9_1Stage1 = new PixelMapping
        {
            X = 549,
            Y = 174,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_1Stage2 = new PixelMapping
        {
            X = 298,
            Y = 212,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_1Stage3 = new PixelMapping
        {
            X = 164,
            Y = 312,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_1Stage4 = new PixelMapping
        {
            X = 337,
            Y = 428,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_1Stage5 = new PixelMapping
        {
            X = 561,
            Y = 362,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_2Anchor_1 = new PixelMapping
        {
            X = 454,
            Y = 283,
            Color = 13153111,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World9_2Anchor_2 = new PixelMapping
        {
            X = 520,
            Y = 257,
            Color = 923416,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World9_2Stage10 = new PixelMapping
        {
            X = 581,
            Y = 143,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_2Stage6 = new PixelMapping
        {
            X = 343,
            Y = 288,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_2Stage7 = new PixelMapping
        {
            X = 474,
            Y = 212,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_2Stage8 = new PixelMapping
        {
            X = 594,
            Y = 272,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_2Stage9 = new PixelMapping
        {
            X = 716,
            Y = 336,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_3Anchor_1 = new PixelMapping
        {
            X = 671,
            Y = 323,
            Color = 15595004,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World9_3Anchor_2 = new PixelMapping
        {
            X = 354,
            Y = 238,
            Color = 15853140,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World9_3Stage11 = new PixelMapping
        {
            X = 364,
            Y = 386,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_3Stage12 = new PixelMapping
        {
            X = 211,
            Y = 225,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_3Stage13 = new PixelMapping
        {
            X = 342,
            Y = 147,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_3Stage14 = new PixelMapping
        {
            X = 505,
            Y = 199,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World9_3Stage15 = new PixelMapping
        {
            X = 582,
            Y = 291,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World10_1Anchor_1 = new PixelMapping
        {
            X = 642,
            Y = 357,
            Color = 15783795,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World10_1Anchor_2 = new PixelMapping
        {
            X = 571,
            Y = 259,
            Color = 7101997,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World10_1Stage1 = new PixelMapping
        {
            X = 675,
            Y = 158,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World10_1Stage2 = new PixelMapping
        {
            X = 503,
            Y = 177,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World10_1Stage3 = new PixelMapping
        {
            X = 621,
            Y = 221,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World10_1Stage4 = new PixelMapping
        {
            X = 734,
            Y = 263,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World10_1Stage5 = new PixelMapping
        {
            X = 574,
            Y = 387,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World10_2Anchor_1 = new PixelMapping
        {
            X = 451,
            Y = 365,
            Color = 10456933,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World10_2Anchor_2 = new PixelMapping
        {
            X = 557,
            Y = 311,
            Color = 14864783,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World10_2Stage6 = new PixelMapping
        {
            X = 310,
            Y = 241,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World10_2Stage7 = new PixelMapping
        {
            X = 477,
            Y = 194,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World10_2Stage8 = new PixelMapping
        {
            X = 617,
            Y = 250,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World10_2Stage9 = new PixelMapping
        {
            X = 591,
            Y = 366,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World10_2Stage10 = new PixelMapping
        {
            X = 740,
            Y = 328,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_1Anchor_1 = new PixelMapping
        {
            X = 581,
            Y = 91,
            Color = 14523466,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World11_1Anchor_2 = new PixelMapping
        {
            X = 86,
            Y = 139,
            Color = 14197311,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World11_1Stage1 = new PixelMapping
        {
            X = 71,
            Y = 251,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_1Stage2 = new PixelMapping
        {
            X = 209,
            Y = 349,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_1Stage3 = new PixelMapping
        {
            X = 378,
            Y = 373,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_1Stage4 = new PixelMapping
        {
            X = 555,
            Y = 349,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_1Stage5 = new PixelMapping
        {
            X = 640,
            Y = 230,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_2Anchor_1 = new PixelMapping
        {
            X = 208,
            Y = 143,
            Color = 12742976,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World11_2Anchor_2 = new PixelMapping
        {
            X = 716,
            Y = 156,
            Color = 14933068,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World11_2Stage1 = new PixelMapping
        {
            X = 703,
            Y = 293,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_2Stage2 = new PixelMapping
        {
            X = 614,
            Y = 168,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_2Stage3 = new PixelMapping
        {
            X = 384,
            Y = 274,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_2Stage4 = new PixelMapping
        {
            X = 362,
            Y = 437,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_2Stage5 = new PixelMapping
        {
            X = 255,
            Y = 336,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping World11_2Stage6 = new PixelMapping
        {
            X = 817,
            Y = 325,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_2Stage7 = new PixelMapping
        {
            X = 713,
            Y = 176,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_2Stage8 = new PixelMapping
        {
            X = 449,
            Y = 299,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_2Stage9 = new PixelMapping
        {
            X = 418,
            Y = 495,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World11_2Stage10 = new PixelMapping
        {
            X = 291,
            Y = 372,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World12_1Anchor_1 = new PixelMapping
        {
            X = 337,
            Y = 168,
            Color = 3682352,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World12_1Anchor_2 = new PixelMapping
        {
            X = 300,
            Y = 181,
            Color = 16709841,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping World12_1Stage1 = new PixelMapping
        {
            X = 139,
            Y = 172,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World12_1Stage2 = new PixelMapping
        {
            X = 212,
            Y = 237,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World12_1Stage3 = new PixelMapping
        {
            X = 155,
            Y = 310,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World12_1Stage4 = new PixelMapping
        {
            X = 276,
            Y = 378,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World12_1Stage5 = new PixelMapping
        {
            X = 362,
            Y = 296,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World12_1Stage6 = new PixelMapping
        {
            X = 391,
            Y = 208,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World12_1Stage7 = new PixelMapping
        {
            X = 483,
            Y = 171,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World12_1Stage8 = new PixelMapping
        {
            X = 567,
            Y = 229,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World12_1Stage9 = new PixelMapping
        {
            X = 646,
            Y = 319,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping World12_1Stage10 = new PixelMapping
        {
            X = 761,
            Y = 245,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}