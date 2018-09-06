namespace GildedRoseTavern.QualityStrategy
{
    public class NormalItemQualityStrategy : QualityStrategy
    {
        public NormalItemQualityStrategy(Item item) : base(item)
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
    }
}
