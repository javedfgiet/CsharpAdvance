using System;

namespace CsharpAdvance.LambdaExpression
{
    public class LambdaExpression
    {
        public int Square(int number)
        {
            return number * number;
        }
    }

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //var obj = new LambdaExpression();
    //        Func<int, int> Square = n => n * n;
    //        Console.WriteLine(Square(5));

    //    }

    //}

     //static void Main(string[] args)
     //   {
     //       /*
     //        * 
     //        *  args => expression
     //        *  () => ...
     //        *  x => ..
     //        *  (x,y,z) => ..
     //        */

     //       const int factor = 5;
     //       Func<int, int> multiplier = n => n * factor;

     //       var result = multiplier(10);
     //       Console.WriteLine(result);

     //   }
    }
