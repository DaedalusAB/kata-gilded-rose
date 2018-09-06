namespace GildedRoseTavern.QualityStrategy
{
    public static class QualityStrategyFactory
    {
        public static QualityStrategy GetFactoryFor(Item item)
        {
            switch (item.Name)
            {
                case (GildedRose.AgedBrie):
                    return new AgedBrieQualityStrategy(item);
                case (GildedRose.BackstagePasses):
                    return new BackstagePassesQualityStrategy(item);
                case (GildedRose.Sulfuras):
                    return new SulfurasQualityStrategy(item);
                default:
                    return new NormalItemQualityStrategy(item);
            }
        }
    }
}
