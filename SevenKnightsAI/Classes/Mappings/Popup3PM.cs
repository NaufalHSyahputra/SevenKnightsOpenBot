namespace SevenKnightsAI.Classes.Mappings
{
    internal class Popup3PM
    {

        /* Special Quest Popup */
        public static readonly PixelMapping QuestCharacterPic = new PixelMapping
        {
            X = 201,
            Y = 177,
            Color = 10803678,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestPoint1 = new PixelMapping
        {
            X = 264,
            Y = 308,
            Color = 5103082,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestPoint2 = new PixelMapping //Pentagon Card
        {
            X = 784,
            Y = 294,
            Color = 8603194,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestRedCrossButton = new PixelMapping
        {
            X = 828,
            Y = 96,
            Color = 13057291,
            Type = MappingType.BOTH
        };

        /* Package & Bazzar Shop */
        public static readonly PixelMapping EventPackPoint1 = new PixelMapping // Ribbon LEft
        {
            X = 263,
            Y = 40,
            Color = 3507952,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping EventPackPoint2 = new PixelMapping // Ribbon Right
        {
            X = 698,
            Y = 41,
            Color = 2326754,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping EventPackCloseBtn = new PixelMapping
        {
            X = 901,
            Y = 40,
            Color = 16777215,
            Type = MappingType.BOTH
        };

        /* Package Shop */
        public static readonly PixelMapping OneDollarPoint1 = new PixelMapping // "P" in "PACKAGE"
        {
            X = 397,
            Y = 200,
            Color = 12513781,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OneDollarPoint2 = new PixelMapping // "P" in "SHOP"
        {
            X = 583,
            Y = 235,
            Color = 16347470,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OneDollarCloseBtn = new PixelMapping
        {
            X = 813,
            Y = 84,
            Color = 12991755,
            Type = MappingType.BOTH
        };

        /*Common Popup*/
        public static readonly PixelMapping PopupBorderTop = new PixelMapping
        {
            X = 109,
            Y = 108,
            Color = 14599052,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderBottom = new PixelMapping
        {
            X = 851,
            Y = 438,
            Color = 9200953,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupCloseBtn = new PixelMapping
        {
            X = 826,
            Y = 58,
            Color = 0,
            Type = MappingType.BUTTON
        };

    }
}
