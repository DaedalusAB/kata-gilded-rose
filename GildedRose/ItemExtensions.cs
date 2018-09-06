namespace GildedRoseTavern
{
    public static class ItemExtensions
    {
        public static bool SellDateHasPassed(this Item item)
        {
            return item.SellIn < 0;
        }

        public static void IncreaseQuality(this Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }

        public static void IncreaseQualityBy(this Item item, int value)
        {
            if (item.Quality + value <= 50)
            {
                item.Quality += value;
            }
            else if (item.Name != GildedRose.Sulfuras)
            {
                item.Quality = 50;
            }
        }

        public static void DecreaseQuality(this Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }

        public static void MakeQualityZero(this Item item)
        {
            item.Quality = 0;
        }
    }
}
