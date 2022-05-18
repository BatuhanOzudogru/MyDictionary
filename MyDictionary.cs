using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary20Ocak2021Odev
{
    class MyDictionary<Key,Value>
    {
        Key[] anahtarlar;
        Value[] degerler;

        public MyDictionary()
        {
            anahtarlar = new Key[0];
            degerler = new Value[0];


        }

        public void Add(Key anahtar, Value deger)
        {
            Key[] tempArray1 = anahtarlar;
            Value[] tempArray2 = degerler;

            anahtarlar = new Key[anahtarlar.Length + 1];
            degerler = new Value[degerler.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                anahtarlar[i] = tempArray1[i];
                degerler[i] = tempArray2[i];
            }

            anahtarlar[anahtarlar.Length - 1] = anahtar;
            degerler[degerler.Length - 1] = deger;
        }

            public int Count
            {

             get { return anahtarlar.Length; }
            }
    }

    }

    





