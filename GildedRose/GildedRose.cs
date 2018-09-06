using System.Collections.Generic;

namespace GildedRoseTavern
{
    public class GildedRose
    {
        IList<Item> Items;

        public static string AgedBrie = "Aged Brie";
        public static string Sulfuras = "Sulfuras, Hand of Ragnaros";
        public static string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";


        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name != AgedBrie && item.Name != BackstagePasses && item.Name != Sulfuras)
                {
                    item.DecreaseQuality();
                }
                else
                {
                    item.IncreaseQuality();

                    if (item.Name == BackstagePasses)
                    {
                        if (item.SellIn < 11)
                        {
                            item.IncreaseQuality();
                        }

                        if (item.SellIn < 6)
                        {
                            item.IncreaseQuality();
                        }
                    }
                }

                if (item.Name != Sulfuras)
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellDateHasPassed())
                {
                    if (item.Name != AgedBrie)
                    {
                        if (item.Name != BackstagePasses)
                        {
                            if (item.Name != Sulfuras)
                            {
                                item.DecreaseQuality();
                            }
                        }
                        else
                        {
                            item.MakeQualityZero();
                        }
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            item.IncreaseQuality();
                        }
                    }
                }
            }
        }
    }
}
