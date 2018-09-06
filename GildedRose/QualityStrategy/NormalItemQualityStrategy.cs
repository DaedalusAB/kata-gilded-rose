namespace GildedRoseTavern.QualityStrategy
{
    public class NormalItemQualityStrategy : QualityStrategy
    {
        public NormalItemQualityStrategy(Item item) : base(item)
        {
        }
        public override void UpdateQualityBeforeSellDate()
        {
            _item.DecreaseQuality();
        }

        public override void UpdateQualityAfterSellDate()
        {
            _item.DecreaseQuality();
        }
    }
}
