namespace GildedRoseTavern.QualityStrategy
{
    public class SulfurasUpdateStrategy : UpdateStrategy
    {
        public SulfurasUpdateStrategy(Item item) : base(item)
        {
        }

        protected override void DecreaseSellIn()
        {
            return;
        }

        protected override void UpdateQuality()
        {
            return;
        }
    }
}
