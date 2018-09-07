namespace GildedRoseTavern.QualityStrategy
{
    public static class UpdateStrategyFactory
    {
        public const string AgedBrie = "Aged Brie";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        public const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        public const string ConjuredManaCake = "Conjured Mana Cake";

        public static UpdateStrategy GetStrategyFor(Item item)
        {
            switch (item.Name)
            {
                case (AgedBrie):
                    return new AgedBrieUpdateStrategy(item);
                case (BackstagePasses):
                    return new BackstagePassesUpdateStrategy(item);
                case (Sulfuras):
                    return new SulfurasUpdateStrategy(item);
                case (ConjuredManaCake):
                    return new ConjuredItemUpdateStrategy(item);
                default:
                    return new NormalItemUpdateStrategy(item);
            }
        }
    }
}
