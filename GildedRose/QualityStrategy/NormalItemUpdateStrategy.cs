namespace GildedRoseTavern.QualityStrategy
{
    public class NormalItemUpdateStrategy : UpdateStrategy
    {
        public NormalItemUpdateStrategy(Item item) : base(item)
        {
        }

        protected override void DecreaseSellIn() =>
            Item.DecreaseSellIn();

        protected override void UpdateQuality() =>
            Item.DecreaseQualityBy(!Item.SellDateHasPassed() ? 1 : 2);
    }
}
