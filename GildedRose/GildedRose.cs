using System.Collections.Generic;
using GildedRoseTavern.QualityStrategy;

namespace GildedRoseTavern
{
    public class GildedRose
    {
        readonly IList<Item> _items;

        public const string AgedBrie = "Aged Brie";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        public const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";


        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                var qualtiyStrategy = QualityStrategyFactory.GetFactoryFor(item);
                qualtiyStrategy.UpdateQualityBeforeSellDate();

                if (item.Name != Sulfuras)
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellDateHasPassed())
                {
                    qualtiyStrategy.UpdateQualityAfterSellDate();
                }
            }
        }
    }
}
