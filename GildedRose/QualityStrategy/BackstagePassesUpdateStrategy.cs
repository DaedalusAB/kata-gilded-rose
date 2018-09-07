namespace GildedRoseTavern.QualityStrategy
{
    public class BackstagePassesUpdateStrategy : UpdateStrategy
    {
        public BackstagePassesUpdateStrategy(Item item) : base(item)
        {
        }

        protected override void DecreaseSellIn() =>
            Item.DecreaseSellIn();

        protected override void UpdateQuality()
        {
            if (Item.SellIn < 0)
            {
                Item.MakeQualityZero();
            }
            else if (Item.SellIn < 5)
            {
                Item.IncreaseQualityBy(3);
            }
            else if (Item.SellIn < 10)
            {
                Item.IncreaseQualityBy(2);
            }
            else
            {
                Item.IncreaseQualityBy(1);
            }
        }

    }
}
