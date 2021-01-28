using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{

    //consructer nedir? ctor yaz taptap tuşuna bas
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items= new T[0];
        }
      public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1]; //length dizinin eleman sayısını arttırır.
            for (int i = 0; i < length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length - 1] = item;
        }

         

    }
}
