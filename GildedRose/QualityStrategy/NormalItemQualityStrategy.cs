namespace GildedRoseTavern.QualityStrategy
{
    public class NormalItemQualityStrategy : QualityStrategy
    {
        public override void UpdateQualityBeforeSellDate(Item item)
        {
            item.DecreaseQuality();
        }

        public override void UpdateQualityAfterSellDate(Item item)
        {
            item.DecreaseQuality();
        }
    }
}
