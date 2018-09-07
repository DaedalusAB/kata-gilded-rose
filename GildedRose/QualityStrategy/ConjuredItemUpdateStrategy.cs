namespace GildedRoseTavern.QualityStrategy
{
    public class ConjuredItemUpdateStrategy : UpdateStrategy
    {
        public ConjuredItemUpdateStrategy(Item item) : base(item)
        {
        }

        public override void UpdateQuality() =>
            _item.DecreaseQualityBy(!_item.SellDateHasPassed() ? 2 : 4);

        public override void DecreaseSellIn() =>
            _item.SellIn--;
    }
}
