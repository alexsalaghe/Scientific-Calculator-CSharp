using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    public class HistoryManager
    {
        private readonly List<HistoryItem> _items = new List<HistoryItem>();

        public void Add(string expression, double result)
        {
            _items.Add(new HistoryItem(expression, result));
        }

        public IReadOnlyList<HistoryItem> All
        {
            get { return _items.AsReadOnly(); }
        }

        public IReadOnlyList<HistoryItem> GetLast(int count)
        {
            if (count <= 0)
            {
                return Array.Empty<HistoryItem>();
            }

            int start = Math.Max(_items.Count - count, 0);
            return _items.GetRange(start, _items.Count - start).AsReadOnly();
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}
