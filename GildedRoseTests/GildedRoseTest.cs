using System.Collections.Generic;
using GildedRoseTavern;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQualityOfConjuredItem()
        {
            IList<Item> Items = new List<Item> { new ConjuredItem() { Name = "foo", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(8, Items[0].Quality);
        }

        [Fact]
        public void UpdateQualityOfConjuredItemAfterSellDateHasPassed()
        {
            IList<Item> Items = new List<Item> { new ConjuredItem() { Name = "foo", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(6, Items[0].Quality);
        }
    }
}
