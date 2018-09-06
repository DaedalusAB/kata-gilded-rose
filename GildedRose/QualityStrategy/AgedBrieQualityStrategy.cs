namespace GildedRoseTavern.QualityStrategy
{
    public class AgedBrieQualityStrategy : QualityStrategy
    {
        public AgedBrieQualityStrategy(Item item) : base(item)
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
    }
}
