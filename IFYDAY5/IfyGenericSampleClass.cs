using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class GenericSampleClass<T>
    {
        private T Id;

        public T GetId() { 
            return Id; 
        }

    }



    public class MyDictionary<TKey, TValue>
    {
        public TKey[] Keys = new TKey[10];
        public TValue[] Values = new TValue[10];

        private static int counter = 0;

        public void Add(TKey key, TValue value)
        {
            if(counter >= 10)
            {
                throw new OutOfMemoryException();
            }

            Keys[counter] = key;
            Values[counter] = value;
            counter++;
        }

        public void Print()
        {
            for(int i=0; i< counter; i++)
            {
                Console.WriteLine($"Key: {Keys[i]} - Value {Values[i]}");
            }
        }
    }


}
