namespace GildedRoseTavern
{
    public static class ItemExtensions
    {
        public static void IncreaseQualityBy(this Item item, int value)
        {
            if (item.Quality + value <= 50)
            {
                item.Quality += value;
            }
            else
            {
                item.Quality = 50;
            }
        }

        public static void DecreaseQualityBy(this Item item, int value)
        {
            if (item.Quality - value >= 0)
            {
                item.Quality -= value;
            }
            else
            {
                item.Quality = 0;
            }
        }

        public static void MakeQualityZero(this Item item)
        {
            item.Quality = 0;
        }

        public static void DecreaseSellIn(this Item item)
        {
            item.SellIn--;
        }

        public static bool SellDateHasPassed(this Item item)
        {
            return item.SellIn < 0;
        }
    }
}
