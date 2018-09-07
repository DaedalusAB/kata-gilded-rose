using System.Collections.Generic;
using GildedRoseTavern.QualityStrategy;

namespace GildedRoseTavern
{
    public class GildedRose
    {
        readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                UpdateStrategyFactory.GetStrategyFor(item).Update();
            }
        }
    }
}
