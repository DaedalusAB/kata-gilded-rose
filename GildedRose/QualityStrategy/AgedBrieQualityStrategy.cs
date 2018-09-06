namespace GildedRoseTavern.QualityStrategy
{
    public class AgedBrieQualityStrategy : QualityStrategy
    {
        public override void UpdateQualityBeforeSellDate(Item item)
        {
            item.IncreaseQuality();
        }

        public override void UpdateQualityAfterSellDate(Item item)
        {
            item.IncreaseQuality();
        }
    }
}
