using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
  public class KeyBoard

    {

        public int this[string key]
        {
            get
            {
                return dict[key];
            }
          
        }

        public string this[int keyValue]
        {
            get
            {
                foreach (var i in dict)
                {
                    if(i.Value == keyValue)
                    {
                        return i.Key;
                    }
                }
                return null;
            }
  
        }

        private Dictionary<string, int> dict { get; set; } = new Dictionary<string, int>();

        public void Output(string key, int keyValue)
        {
            dict.Add(key, keyValue);
        }
    }
}
