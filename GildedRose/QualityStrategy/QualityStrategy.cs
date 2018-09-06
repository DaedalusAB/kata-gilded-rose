namespace GildedRoseTavern.QualityStrategy
{
    public abstract class QualityStrategy
    {
        public abstract void UpdateQualityBeforeSellDate(Item item);
        public abstract void UpdateQualityAfterSellDate(Item item);
    }
}
