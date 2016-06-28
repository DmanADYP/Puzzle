using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] a = new object[] { "X", 4, "B", 2, "C", 3,"X", 2};
            object[] B = new object[] { "B", 2, "C", 2, "X", 2, "X",4 };

            IEnumerable<object> x = a.AsEnumerable();
      
            foreach (var item in parser(a))
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
        public static object[] parser(object[] a)
        {
            //string[] sArray = new string[] { };
            //int[] iArray = new int[] { };
            List<string> sArray = new List<string>();
            List<int> iArray = new List<int>();
            List<object> oArray = new List<object>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] is string)
                {
                    sArray.Add(Convert.ToString(a[i]));
                  
                }
                else if (a[i] is int)
                {
                    iArray.Add(Convert.ToInt32(a[i]));
                   
                }

              
            }
            sArray.Sort();
            iArray.Sort();
      
            foreach (var item in sArray.Zip(iArray, Tuple.Create))
            {

                oArray.Add(item.Item1);
                oArray.Add(item.Item2);
            }
            return oArray.ToArray() ;
        }
    }
  
        
}
