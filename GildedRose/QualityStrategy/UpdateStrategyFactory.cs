namespace GildedRoseTavern.QualityStrategy
{
    public static class UpdateStrategyFactory
    {
        public static UpdateStrategy GetStrategyFor(Item item)
        {
            switch (item.Name)
            {
                case (GildedRose.AgedBrie):
                    return new AgedBrieUpdateStrategy(item);
                case (GildedRose.BackstagePasses):
                    return new BackstagePassesUpdateStrategy(item);
                case (GildedRose.Sulfuras):
                    return new SulfurasUpdateStrategy(item);
                case (GildedRose.ConjuredManaCake):
                    return new ConjuredItemUpdateStrategy(item);
                default:
                    return new NormalItemUpdateStrategy(item);
            }
        }
    }
}
