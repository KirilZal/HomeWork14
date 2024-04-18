using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Extensions
    {
        public static T[] GetArray<T>(this IEnumerable _list)
        {
            
            int count = 0;
            foreach (var item in _list)
            {
                count++;
            }

          
            T[] array = new T[count];

            
            int index = 0;
            foreach (var item in _list)
            {
                array[index] = (T)item;
                index++;
            }

            return array;
        }
    }
}
