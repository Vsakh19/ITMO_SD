using System.Collections.Generic;

namespace WpfApplicationChart
{

    class Model
    {
        public IList<Data> Data
        {
            get
            {
                IList<Data> list = new List<Data>
                    {
                    new Data("A", 10),
                    new Data("B", 20),
                    new Data("C", 30),
                    new Data("D", 40),
                    new Data("E", 50)
                    };
                return list;
            }
        }
    }
    public class Data
    {
        public Data(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
