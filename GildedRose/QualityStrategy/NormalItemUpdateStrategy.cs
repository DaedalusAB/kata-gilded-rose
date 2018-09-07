namespace GildedRoseTavern.QualityStrategy
{
    public class NormalItemUpdateStrategy : UpdateStrategy
    {
        public NormalItemUpdateStrategy(Item item) : base(item)
        {
        }
        public override void UpdateQuality()
        {
            if (!_item.SellDateHasPassed())
            {
                _item.DecreaseQuality();
            }
            else
            {
                _item.DecreaseQualityBy(2);
            }
        }

        public override void DecreaseSellIn() =>
            _item.SellIn--;
    }
}
