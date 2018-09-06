namespace GildedRoseTavern.QualityStrategy
{
    class ConjuredItemQualityStrategy : QualityStrategy
    {
        public ConjuredItemQualityStrategy(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            if (!_item.SellDateHasPassed())
            {
                _item.DecreaseQualityBy(2);
            }
            else
            {
                _item.DecreaseQualityBy(4);
            }
        }
    }
}
