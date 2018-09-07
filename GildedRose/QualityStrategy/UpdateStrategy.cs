namespace GildedRoseTavern.QualityStrategy
{
    public abstract class UpdateStrategy
    {
        protected Item _item;

        protected UpdateStrategy(Item item)
        {
            _item = item;
        }

        public abstract void UpdateQuality();
        public abstract void DecreaseSellIn();

        public void Update()
        {
            DecreaseSellIn();
            UpdateQuality();
        }
    }
}
