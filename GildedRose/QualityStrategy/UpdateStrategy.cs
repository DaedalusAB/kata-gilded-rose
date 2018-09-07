namespace GildedRoseTavern.QualityStrategy
{
    public abstract class UpdateStrategy
    {
        protected Item Item { get; }

        protected UpdateStrategy(Item item)
        {
            Item = item;
        }

        protected abstract void DecreaseSellIn();

        protected abstract void UpdateQuality();

        public void Update()
        {
            DecreaseSellIn();
            UpdateQuality();
        }
    }
}
