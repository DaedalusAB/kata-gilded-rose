namespace GildedRoseTavern.QualityStrategy
{
    public class BackstagePassesQualityStrategy : QualityStrategy
    {
        public override void UpdateQualityBeforeSellDate(Item item)
        {
            if (item.SellIn <= 5)
            {
                item.IncreaseQualityBy(3);
            }
            else if (item.SellIn <= 10)
            {
                item.IncreaseQualityBy(2);
            }
            else
            {
                item.IncreaseQuality();
            }
        }

        public override void UpdateQualityAfterSellDate(Item item)
        {
            item.MakeQualityZero();
        }
    }
}
