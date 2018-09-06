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
