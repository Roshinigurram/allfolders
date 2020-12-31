using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    class Class3
    {
        public void mymethod()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("32","rosh");
            hashtable.Add("12", "hkdj");
            hashtable.Add("21", "shdkj");

            Parallel.For(0, hashtable.Count, (item) =>
            {
                var index = (DictionaryEntry)hashtable [item];
                Console.WriteLine(index.Key);
            });

        }

    }
}
