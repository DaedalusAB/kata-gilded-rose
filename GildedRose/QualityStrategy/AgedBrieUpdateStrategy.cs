namespace GildedRoseTavern.QualityStrategy
{
    public class AgedBrieUpdateStrategy : UpdateStrategy
    {
        public AgedBrieUpdateStrategy(Item item) : base(item)
        {
        }

        protected override void DecreaseSellIn() =>
            Item.DecreaseSellIn();

        protected override void UpdateQuality() =>
            Item.IncreaseQualityBy(!Item.SellDateHasPassed() ? 1 : 2);
    }
}
