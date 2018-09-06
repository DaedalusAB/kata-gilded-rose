namespace GildedRoseTavern.QualityStrategy
{
    public class SulfurasQualityStrategy : QualityStrategy
    {
        public SulfurasQualityStrategy(Item item) : base(item)
        {
            
        }
        public override void UpdateQualityBeforeSellDate()
        {
            return;
        }

        public override void UpdateQualityAfterSellDate()
        {
            return;
        }
    }
}
