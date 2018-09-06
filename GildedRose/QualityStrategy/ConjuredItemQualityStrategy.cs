namespace GildedRoseTavern.QualityStrategy
{
    class ConjuredItemQualityStrategy : QualityStrategy
    {
        public ConjuredItemQualityStrategy(Item item) : base(item)
        {
        }

        public override void UpdateQualityBeforeSellDate()
        {
            _item.DecreaseQualityBy(2);
        }

        public override void UpdateQualityAfterSellDate()
        {
            _item.DecreaseQualityBy(2);
        }
    }
}
