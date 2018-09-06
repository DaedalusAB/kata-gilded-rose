using System.Collections.Generic;
using GildedRoseTavern;
using Xunit;

namespace GildedRoseTests
{
    public class ConjuredItemTests
    {
        [Fact]
        public void UpdateQualityOfConjuredItem()
        {
            var items = new List<Item> { new ConjuredItem() { Name = "ConjuredFoo", SellIn = 10, Quality = 10 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal(8, items[0].Quality);
        }

        [Fact]
        public void UpdateQualityOfConjuredItemAfterSellDateHasPassed()
        {
            var items = new List<Item> { new ConjuredItem() { Name = "ConjuredFoo", SellIn = 0, Quality = 10 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal(6, items[0].Quality);
        }
    }
}
