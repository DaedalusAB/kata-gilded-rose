namespace GildedRoseTavern.QualityStrategy
{
    public class BackstagePassesQualityStrategy : QualityStrategy
    {
        public BackstagePassesQualityStrategy(Item item) : base(item)
        {
        }

        public override void UpdateQualityBeforeSellDate()
        {
            if (_item.SellIn <= 5)
            {
                _item.IncreaseQualityBy(3);
            }
            else if (_item.SellIn <= 10)
            {
                _item.IncreaseQualityBy(2);
            }
            else
            {
                _item.IncreaseQuality();
            }
        }

        public override void UpdateQualityAfterSellDate()
        {
            _item.MakeQualityZero();
        }
    }
}
