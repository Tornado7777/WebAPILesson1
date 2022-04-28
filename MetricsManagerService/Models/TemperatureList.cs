using System;
using System.Collections.Generic;

namespace MetricsManagerService.Models
{
    public class TemperatureList
    {
        private List<Temperature> _temperatures;

        public List<Temperature> Temperatures
        {
            get { return _temperatures; }
            set { _temperatures = value; }
        }

        public TemperatureList()
        {
            _temperatures = new List<Temperature>();
        }


        public void Add(Temperature value)
        {
            _temperatures.Add(value);
        }

        public List<Temperature> Get()
        {
            return _temperatures;
        }

        public Temperature GetTeperatureToTime(TimeSpan toTime)
        {
            Temperature findTemp = _temperatures.Find(x => x.Date == toTime);
            return findTemp;
        }

        public void EditToTime(int temperature, TimeSpan toTime)
        {

            int index = _temperatures.FindIndex(x => x.Date == toTime);
            if (index >= 0) _temperatures[index].TemperatureC = temperature;

        }

        public void DeletedRangeTime(TimeSpan FromTime, TimeSpan toTime)
        {
            int index = 0;
            do
            {
                index = _temperatures.FindIndex(x => (x.Date >= FromTime && x.Date <= toTime));
                if (index >= 0) _temperatures.RemoveAt(index);
            }
            while (index >= 0);
        }
        
        public string ReadRangeTime(TimeSpan FromTime, TimeSpan toTime)
        {
            int index = 0;
            string tempRangeTime = "";
            do
            {
                index = _temperatures.FindIndex(index, x => (x.Date >= FromTime && x.Date <= toTime));
                if (index >= 0)
                {
                    tempRangeTime += "Date " + _temperatures[index].Date.ToString() + " Temperature C: " + _temperatures[index].TemperatureC.ToString() + "\n";
                    index++;
                }
            }
            while (index >= 0);
            return tempRangeTime;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < _temperatures.Count; i++)
            {
                result += "Time " + _temperatures[i].Date.ToString() + " Temperature C: " + _temperatures[i].TemperatureC.ToString() + "\n";
            }
            return result;
        }
    }
}
