using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_01
{
  public class Dictionary
    {

        public int this[string key,int value]
        {
            get
            {
                return dict[key];  //not dict.key,, it returns value
            }
        }

        public string this[int value,string key]
        {
            get
            {
                foreach(var item in dict)
                {
                    if(item.Value == value)
                    {
                        return item.Key;    //it returns key
                    }
                }

                return null;
            }
        }
        private Dictionary<string,int> dict {  get; set; } = new Dictionary<string,int>();

        public void AddItems(string key, int value)
        {
            dict.Add(key, value);
        }
    }
}
