namespace GildedRoseTavern.QualityStrategy
{
    public class AgedBrieUpdateStrategy : UpdateStrategy
    {
        public AgedBrieUpdateStrategy(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            if (!_item.SellDateHasPassed())
            {
                _item.IncreaseQuality();
            }
            else 
            {
                _item.IncreaseQualityBy(2);
            }
        }

        public override void DecreaseSellIn() =>
            _item.SellIn--;
    }
}
