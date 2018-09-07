namespace GildedRoseTavern.QualityStrategy
{
    public class ConjuredItemUpdateStrategy : UpdateStrategy
    {
        public ConjuredItemUpdateStrategy(Item item) : base(item)
        {
        }

        protected override void DecreaseSellIn() =>
            Item.DecreaseSellIn();

        protected override void UpdateQuality() =>
            Item.DecreaseQualityBy(!Item.SellDateHasPassed() ? 2 : 4);

    }
}
