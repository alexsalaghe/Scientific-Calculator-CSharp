using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    public class HistoryItem
    {
        private readonly string _expression;
        private readonly double _result;
        private readonly DateTime _timestamp;

        public string Expression
        {
            get { return _expression; }
        }

        public double Result
        {
            get { return _result; }
        }

        public DateTime Timestamp
        {
            get { return _timestamp; }
        }

        public HistoryItem(string expression, double result)
        {
            _expression = expression;
            _result = result;
            _timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format("{0} = {1}", _expression, _result);
        }
    }
}
