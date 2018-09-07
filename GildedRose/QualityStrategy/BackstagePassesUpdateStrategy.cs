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
            if (Item.SellDateHasPassed())
            {
                Item.MakeQualityZero();
            }
            else 
            {
                Item.IncreaseQualityBy(QualityIncreaseBasedOnSellIn());
            }
        }

        private int QualityIncreaseBasedOnSellIn()
        {
            if (Item.SellIn < 5)
            {
                return 3;
            }

            if (Item.SellIn < 10)
            {
                return 2;
            }

            return 1;
        }
    }
}
