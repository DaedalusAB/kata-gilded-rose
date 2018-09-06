namespace GildedRoseTavern.QualityStrategy
{
    public class AgedBrieQualityStrategy : QualityStrategy
    {
        public AgedBrieQualityStrategy(Item item) : base(item)
        {
        }

        public override void UpdateQualityBeforeSellDate()
        {
            _item.IncreaseQuality();
        }

        public override void UpdateQualityAfterSellDate()
        {
            _item.IncreaseQuality();
        }
    }
}
