using CsharpAdvance.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var number=new Generics.Nullable<int>();
            Console.WriteLine("Has value ?" + number.HasValue);
            Console.WriteLine("Value:"+number.GetValueOrDefault());
        }
    }


}
