using System.Collections.Generic;
using GildedRoseTavern.QualityStrategy;

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
                if (item.Name == AgedBrie)
                {
                    new AgedBrieQualityStrategy().UpdateQualityBeforeSellDate(item);
                }
                else if (item.Name == Sulfuras)
                {
                    new SulfurasQualityStrategy().UpdateQualityBeforeSellDate(item);
                }
                else if (item.Name == BackstagePasses)
                {
                    new BackstagePassesQualityStrategy().UpdateQualityBeforeSellDate(item);
                }
                else
                {
                    new NormalItemQualityStrategy().UpdateQualityBeforeSellDate(item);
                }

                if (item.Name != Sulfuras)
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellDateHasPassed())
                {
                    if (item.Name == AgedBrie)
                    {
                        new AgedBrieQualityStrategy().UpdateQualityAfterSellDate(item);
                    }
                    else if (item.Name == Sulfuras)
                    {
                        new SulfurasQualityStrategy().UpdateQualityAfterSellDate(item);
                    }
                    else if (item.Name == BackstagePasses)
                    {
                        new BackstagePassesQualityStrategy().UpdateQualityAfterSellDate(item);
                    }
                    else
                    {
                        new NormalItemQualityStrategy().UpdateQualityAfterSellDate(item);
                    }
                }
            }
        }
    }
}
