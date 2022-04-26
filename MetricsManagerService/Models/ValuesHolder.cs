using System.Collections.Generic;

namespace MetricsManagerService.Models
{
    public class ValuesHolder
    {

        private List<string> _values;

        public ValuesHolder()
        {
            _values = new List<string>();
        }

        public void Add(string value)
        {
            _values.Add(value);
        }

        public string Get()
        {
            return string.Join(',', _values.ToArray());
        }

        public List<string> Values
        {
            get { return _values; }
            set { _values = value; }
        }

    }
}
