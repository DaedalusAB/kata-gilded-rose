namespace GildedRoseTavern.QualityStrategy
{
    public abstract class QualityStrategy
    {
        protected Item _item;

        protected QualityStrategy(Item item)
        {
            _item = item;
        }

        public abstract void UpdateQualityBeforeSellDate();
        public abstract void UpdateQualityAfterSellDate();
    }
}
