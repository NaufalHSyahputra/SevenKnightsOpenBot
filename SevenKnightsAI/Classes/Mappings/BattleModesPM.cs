namespace SevenKnightsAI.Classes.Mappings
{
    internal static class BattleModesPM
    {
        #region Public Fields

        public static readonly PixelMapping ArenaButton = new PixelMapping
        {
            X = 650,
            Y = 422,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HottimeButton = new PixelMapping
        {
            X = 845,
            Y = 36,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 860,
            Y = 501,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SpecialDungeonButton = new PixelMapping
        {
            X = 216,
            Y = 184,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping BorderBottomRight = new PixelMapping //Adventure Button
        {
            X = 30,
            Y = 24,
            Color = 3422267,
            Type = MappingType.ANCHOR
        };  

        public static readonly PixelMapping BorderTopLeft = new PixelMapping //Back Button
        {
            X = 752,
            Y = 485,
            Color = 7195133,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BossFightButton = new PixelMapping
        {
            X = 398,
            Y = 197,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CastleRushButton = new PixelMapping
        {
            X = 654,
            Y = 186,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping QuestRedScroll = new PixelMapping
        {
            X = 924,
            Y = 507,
            Color = 15396095,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GuildWarButton = new PixelMapping
        {
            X = 422,
            Y = 310,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}