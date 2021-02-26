using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        //Değişken tanımladık
        TKey[] keys;
        TValue[] values;

        //constructor bloğu(newlediğimizde çalışıcak olan blok) bir metotdur.
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        //işlem bloğumuz yani metodumuz.
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeysArray = keys;
            keys = new TKey[keys.Length + 1];
            

            for (int i = 0; i < tempKeysArray.Length; i++)
            {
                keys[i] = tempKeysArray[i];
            }
            keys[keys.Length - 1] = key;

            TValue[] tempValuesArray = values;
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempValuesArray.Length; i++)
            {
                values[i] = tempValuesArray[i];
            }
            values[values.Length - 1] = value;
        }
        //ekrana yazdırma metotdumuz
        public void List()
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Seri Numarası : " + keys[i] + " " + "Telefon Marka Ve Modeli : " + values[i]);
            }
        }
    }
    
}
