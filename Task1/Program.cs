using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(10);
            list.Add(20);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"element{i} : {list[i]}");

            }
            foreach(int item  in list)
            {
                Console.WriteLine($"element: - :"+  item);
            }

           int[]array=list.GetArray<int>();
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
            
           
            

        }
    }
}
